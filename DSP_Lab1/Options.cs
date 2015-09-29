using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSP_Lab1.Filter;
using DSP_Lab1.NoiseGenerator;
using DSP_Lab1.SignalGenerator;

namespace DSP_Lab1
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        public void InitOptions(Settings settings)
        {

            if (settings.SignalGenerator is HarmonicSignalGenerator)
            {
                var gen = (HarmonicSignalGenerator) settings.SignalGenerator;
                harmonicFunc.Checked = true;
                nudAmplitude.Value = Convert.ToDecimal(gen.Amplitude);
                nudPhaseShift.Value = Convert.ToDecimal(gen.PhaseShift);
                nudPeriodDel.Value = Convert.ToDecimal(gen.PeriodDel);
            }
            else if (settings.SignalGenerator is StatMeandrSignalGenerator)
            {
                var gen = (StatMeandrSignalGenerator)settings.SignalGenerator;
                statMeandrFunc.Checked = true;
            }
            else if (settings.SignalGenerator is NonStatMeandrSignalGenerator)
            {
                var gen = (NonStatMeandrSignalGenerator)settings.SignalGenerator;
                nonStatMeanFunc.Checked = true;
            }
            else if (settings.SignalGenerator is SumHarmonicSignalGenerator)
            {
                var gen = (SumHarmonicSignalGenerator)settings.SignalGenerator;
                harmonicSumFunc.Checked = true;
            }

            if (settings.NoiseGenerator is WhiteNoiseGenerator)
            {
                var gen = (WhiteNoiseGenerator)settings.NoiseGenerator;
                whiteNoise.Checked = true;
                nudSnrIn.Value = Convert.ToDecimal(gen.Snr);
            }

            rbSaveSignal.Checked = settings.SaveSignal;

        }
        
        private Settings GetSettings()
        {
            var settings = new Settings();

            var checkedFunction = GetCheckedRadioButtonFromGroupBox(gbFunction);
            if (checkedFunction != null)
            {
                switch (checkedFunction.Name)
                {
                    case ("statMeandrFunc"):
                        settings.SignalGenerator = new StatMeandrSignalGenerator();
                        break;
                    case ("harmonicSumFunc"):
                        settings.SignalGenerator = new SumHarmonicSignalGenerator();
                        break;
                    case ("nonStatMeanFunc"):
                        settings.SignalGenerator = new NonStatMeandrSignalGenerator();
                        break;
                    default:
                        settings.SignalGenerator = new HarmonicSignalGenerator((double)nudAmplitude.Value, (double)nudPhaseShift.Value, (double)nudPeriodDel.Value);
                        break;
                }
            }
            else
            {
                settings.SignalGenerator = new HarmonicSignalGenerator();
            }

            var checkedNoise = GetCheckedRadioButtonFromGroupBox(gbNoise);
            if (checkedNoise != null)
            {
                switch (checkedNoise.Name)
                {
                    default:
                        //case ("whiteNoise"):
                        settings.NoiseGenerator = new WhiteNoiseGenerator((double)nudSnrIn.Value);
                        break;
                }
            }
            else
            {
                settings.NoiseGenerator = new WhiteNoiseGenerator();
            }

            settings.Filter = new SumCoherentFilter();
            settings.SaveSignal = rbSaveSignal.Checked;

            return settings;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            ((Form1)this.Owner).Settings = GetSettings();
            this.DialogResult = DialogResult.OK; ;
        }

        private static RadioButton GetCheckedRadioButtonFromGroupBox(GroupBox gb)
        {
            return gb.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }


    }
}
