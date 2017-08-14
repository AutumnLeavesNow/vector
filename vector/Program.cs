using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector<int> v1 = new Vector<int> (3,2);
            Vector<int> v2 = new Vector<int>(3,1);
            v1[0] = 4;
            v2[2] = 9;
            var v3 = v1 * v2;
            var v4 = v1 + v2;
            var v5 = v1 - v2;
            var v6 = new Vector<int>(17, 1);
            var val = v6.VectMod;
        }
    }
}
