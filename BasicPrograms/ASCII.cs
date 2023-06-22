using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class ASCII
    {
        public void Values()
        {
            char a;
            Console.WriteLine("Enter a character");
            a=Convert.ToChar(Console.ReadLine());
            int b = a;
            Console.WriteLine("The ASCII value is"+a+" "+b );
            
        }
    }
}
