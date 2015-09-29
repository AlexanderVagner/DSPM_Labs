using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP_Lab1
{
    public class Signal : IEnumerable<double>
    {
        public double[] Data { get; set; }
        public int Length => Data.Length;

        public double Amplitude => Math.Max(Math.Abs(Data.Max()), Math.Abs(Data.Min()));

        public Signal(int length)
        {
            Data = new double[length];
        }

        public Signal(double[] arr)
        {
            Data = new double[arr.Length];
            Array.Copy(arr,Data,arr.Length);
        }

        public void Reset()
        {
            for (var i = 0; i < Data.Length; i++)
            {
                Data[i] = 0;
            }
        }

        public static Signal operator + (Signal x, Signal y)
        {
            return new Signal(x.Select((el1,index)=>el1+y[index]).ToArray());
        }

        public static Signal operator - (Signal x, Signal y)
        {
            return new Signal(x.Select((el1, index) => el1 - y[index]).ToArray());
        }

        public static Signal operator / (Signal x, int y)
        {
            return new Signal(x.Select((el1, index) => el1 / y).ToArray());
        }

        IEnumerator<double> IEnumerable<double>.GetEnumerator()
        {
            return ((IEnumerable<double>) Data).GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return Data.GetEnumerator();
        }

        public double this[int i]
        {
            get
            {
                return Data[i];
            }
            set
            {
                Data[i] =value;
            }
        }

        public static double CalcSnr(Signal signal, Signal noise)
        {
            return Math.Pow(signal.Amplitude / noise.Amplitude, 2);
        }
    }
}
