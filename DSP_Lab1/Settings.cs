using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSP_Lab1.Filter;
using DSP_Lab1.NoiseGenerator;
using DSP_Lab1.SignalGenerator;

namespace DSP_Lab1
{
    public class Settings
    {
        public INoiseGenerator NoiseGenerator { get; set; }
        public ISignalGenerator SignalGenerator { get; set; }
        public IFilter Filter { get; set; }
        public bool SaveSignal { get; set; }


        public Settings(INoiseGenerator ng,ISignalGenerator sg, IFilter filter, bool saveSignal)
        {
            NoiseGenerator = ng;
            SignalGenerator = sg;
            Filter = filter;
            SaveSignal = saveSignal;
        }

        public Settings()
        {
            NoiseGenerator =  new WhiteNoiseGenerator();
            SignalGenerator =  new HarmonicSignalGenerator();
            Filter =  new SumCoherentFilter();
            SaveSignal = false;
        }
    }
}
