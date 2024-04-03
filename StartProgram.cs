using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApp_Pipeline
{
    internal class StartProgram
    {
        public void Sum(string a, string b)
        {
            Console.WriteLine(a + b);
        }

        public int Sum(int a, int b, int c)
        {
            return (a + b + c);
        }
    }
}
