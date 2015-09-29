using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab1.Filter
{
    public class SumCoherentFilter : IFilter
    {
        private List<Signal> Storage { get; set; }
        
        public SumCoherentFilter()
        {
            Storage = new List<Signal>();
        }

        public void StoreSignal(Signal signal)
        {
            Storage.Add(new Signal(signal.Data));
        }

        public void Reset()
        {
            Storage.Clear();
        }

        public Signal GetFilteredSignal()
        {
            var sumSignal = new Signal(Storage.First().Length);
            for (var i = 0; i < Storage.Count; i++)
            {
                for (var j = 0; j < Storage[i].Length; j++)
                {
                    sumSignal[j] += Storage[i][j];
                }
                
            }
            return sumSignal/Storage.Count;
        }

        public Signal Filter(Signal signal)
        {
            StoreSignal(signal);
            return GetFilteredSignal();
        }
    }
}
