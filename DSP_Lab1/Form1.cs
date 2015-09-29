using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSP_Lab1
{
    public partial class Form1 : Form
    {
        private const int SignalLength = 1000;
        public Settings Settings { get; set; }


        private double _snrOut;
        private bool _signalFiltering;
        private int _filterIterationsCount;
        private int _filterIterationsCounter;
        private Signal _inputSignal;
        private Signal _filteredSignal;

        public double SnrOut
        {
            get { return _snrOut; }
            set
            {
                _snrOut = value;
                lbSnrOut.Text = _snrOut.ToString();
            }
        }

        public Signal InputSignal {
            get { return _inputSignal; }
            set
            {
                _inputSignal = value;
                panlnputSignal.Refresh();
            }
        }

        public Signal FilteredSignal {
            get { return _filteredSignal; }
            set
            {
                _filteredSignal = value;
                panFilteredSignal.Refresh();
            }
        }

        public Form1()
        {
            InitializeComponent();
            Settings = new Settings();
            InitForm();
        }

        private void ResetSignals()
        {
            _filterIterationsCounter = 0;
            InputSignal = Settings.SignalGenerator.Generate(SignalLength);
            FilteredSignal = Settings.NoiseGenerator.ApplyToSignal(InputSignal);
            lbCycleCounter.Text = _filterIterationsCounter.ToString();
            Settings.Filter.Reset();
            CalcSnrOut();
        }

        private void InitForm()
        {
            btnStart.Enabled = true;
            btnReset.Enabled = false;

            panlnputSignal.Paint += PanlnputSignal_Paint;
            panFilteredSignal.Paint += PanFilteredSignal_Paint;

            filterTimer.Tick += (e,a)=> { FilterSignal(); };
            
            ResetSignals();
        }

        private void PanlnputSignal_Paint(object sender, PaintEventArgs e)
        {
            DrawSignal(sender as Panel, e.Graphics, InputSignal);
        }

        private void PanFilteredSignal_Paint(object sender, PaintEventArgs e)
        {
            DrawSignal(sender as Panel, e.Graphics, FilteredSignal);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            var optionsForm = new Options { Owner = this };
            optionsForm.InitOptions(Settings);
            var result = optionsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                InitForm();
            }
        }

        private void DrawSignal(Panel p, Graphics g, Signal signal)
        {
            g.Clear(Color.White);
            g.FillRectangle(new SolidBrush(Color.White), p.DisplayRectangle);
            g.DrawLine(new Pen(Color.Red, 1), new Point(0, p.DisplayRectangle.Height / 2), new Point(p.DisplayRectangle.Width, p.DisplayRectangle.Height / 2));
            var yScale = p.Height / InputSignal.Amplitude / 2;
            yScale = double.IsInfinity(yScale) ? 0 : yScale;
            g.DrawLines(new Pen(Color.Black), signal.Select((y, x) => new PointF((1.0F * x) / (1.0F * SignalLength / signal.Length), (float)(y * yScale) + p.Height / 2.0F)).ToArray());
        }

        private void FilterSignal()
        {
            InputSignal = Settings.SignalGenerator.Generate(SignalLength);
            FilteredSignal =Settings.Filter.Filter(Settings.NoiseGenerator.ApplyToSignal(InputSignal));
            CalcSnrOut();
            if (_filterIterationsCounter++ >= _filterIterationsCount)
            {
                filterTimer.Stop();
                btnReset.Enabled = true;
            }
            else
            {
                lbCycleCounter.Text = _filterIterationsCounter.ToString();
            }
        }

        private void CalcSnrOut()
        {
            var noise = InputSignal - FilteredSignal;
            SnrOut = Signal.CalcSnr(InputSignal, noise);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _signalFiltering = false;
            _filterIterationsCount = (int)nudIterationsCount.Value;
            filterTimer.Interval = Math.Max(100,2000/ _filterIterationsCount);
            btnStart.Enabled = false;
            filterTimer.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetSignals();
            btnStart.Enabled = true;
            btnReset.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
