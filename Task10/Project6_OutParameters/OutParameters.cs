using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module6
{
    class OutParameters
    {
        static void Deprecitaion(out int val)
        {
            val = 20000;
            int dep = val * 5 / 100;
            int amt = val - dep;
            Console.WriteLine("Depreciation Amount: " + dep);
            Console.WriteLine("Reduced value after depreciation" + amt);

        }
        static void Main(string[] args)
        {
            int value;
            Deprecitaion(out value);
        }
    }
}