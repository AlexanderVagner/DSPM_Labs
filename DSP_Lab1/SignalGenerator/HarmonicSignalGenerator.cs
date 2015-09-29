using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab1.SignalGenerator
{
    public class HarmonicSignalGenerator : ISignalGenerator
    {
        public double Amplitude { get; set; }
        public double PhaseShift { get; set; }
        public double PeriodDel { get; set; }

        public HarmonicSignalGenerator(double amplitude = 1, double phaseShift = 0, double periodDel = 1)
        {
            Amplitude = amplitude;
            PhaseShift = phaseShift;
            PeriodDel = periodDel;
        }

        public Signal Generate(int length)
        {
            var sign = new double[length];
            for (var i = 0; i < length; i++)
            {
                var x = i*2*Math.PI/length;
                sign[i] = CalcSignal(x);
            }
            return new Signal(sign);
        }

        private double CalcSignal(double x)
        {
            return Amplitude*Math.Sin(2*x*Math.PI/PeriodDel+PhaseShift);
        }
    }
}
