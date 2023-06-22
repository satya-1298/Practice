using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Swap
    {
        public void Number()
        {
            int a = 10;
            int b = 20; 
            Console.WriteLine("Before swaping a = "+a+" b = "+b);
            int c = a * b;
            a = c / a;
            b = c/ b;
            Console.WriteLine("After swaping a = " + a + " b = " + b);
        }
    }
}
