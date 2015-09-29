using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSP_Lab1.NoiseGenerator
{
    public class WhiteNoiseGenerator : INoiseGenerator
    {
        public double Snr {get; set;}
        private static readonly Random Rnd = new Random();

        public WhiteNoiseGenerator(double snrIn=0.3)
        {
            Snr = snrIn;
        }

        public Signal ApplyToSignal(Signal signal)
        {
            
            return new Signal(signal.Select(y=>y+ (Rnd.Next(0, 10) < 5 ? -1 : 1) * Rnd.NextDouble()*signal.Amplitude/Math.Sqrt(Snr)).ToArray());
        }
    }
}
