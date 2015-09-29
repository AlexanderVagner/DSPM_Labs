using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab1.SignalGenerator
{
    public class NonStatMeandrSignalGenerator : ISignalGenerator
    {
        private const double Amplitude = 1;
        private const double FourierIterationsCount = 51;
        private const double ShiftVal = 0.005 * Math.PI;

        private int _iterationNum = 0;

        public Signal Generate(int length)
        {
            var sign = new double[length];
            for (var i = 0; i < length; i++)
            {
                var x = i * 2 * Math.PI / length + _iterationNum*ShiftVal;
                sign[i] = CalcSignal(x);
            }
            _iterationNum++;
            return new Signal(sign);
        }

        private double CalcSignal(double x)
        {
            var val = 4 * Amplitude / Math.PI;
            var sum = 0.0;
            for (var i = 1; i <= FourierIterationsCount; i += 2)
            {
                sum += Math.Sin(i * 2 * Math.PI * x) / i;
            }

            val *= sum;
            return val;
        }
    }
}
