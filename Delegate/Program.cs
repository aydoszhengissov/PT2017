using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate void PrintDelegate(int[] arr);

    class Class1
    {
        public void CalcSum(int[] arr)
        {
            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }

    class Class2
    {
        public PrintDelegate pd;
        public void CalcSum(int[] arr)
        {
            pd.Invoke(arr);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            c1.CalcSum(new int[] { 1, 2, 3 });
            c2.pd = c1.CalcSum;
            c2.CalcSum(new int[] { 4, 5, 6 });
        }
    }
}
