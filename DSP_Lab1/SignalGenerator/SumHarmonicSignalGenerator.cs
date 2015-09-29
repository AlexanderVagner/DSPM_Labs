using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab1.SignalGenerator
{
    public class SumHarmonicSignalGenerator : ISignalGenerator
    {
        public const double FirstAmplitude = 1;
        public const double SecondAmplitude = 1;
        public const double FirstPeriodDel = 0.2;
        public const double SecondPeriodDel = 1;

        public Signal Generate(int length)
        {
            var sign = new double[length];
            for (var i = 0; i < length; i++)
            {
                var x = i * 2 * Math.PI / length;
                sign[i] = CalcSignal(x);
            }
            return new Signal(sign);
        }

        private double CalcSignal(double x)
        {
            var first = FirstAmplitude * Math.Sin(2 * x * Math.PI / FirstPeriodDel);
            var second = SecondAmplitude * Math.Sin(2 * x * Math.PI / SecondPeriodDel);
            return first + second;
        }
    }
}
