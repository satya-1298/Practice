using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Areaof
    {
        public void Circle()
        {
            Console.WriteLine("Enter a value");
            int r= Convert.ToInt32(Console.ReadLine());
            double a = Math.PI * r * r; //Area of circle formula
            Console.WriteLine("Area of circle is : "+a);
        }
    }
}
