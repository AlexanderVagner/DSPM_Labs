using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab1
{
    public interface IFilter
    {
        Signal Filter(Signal signal);
        void Reset();
    }
}
