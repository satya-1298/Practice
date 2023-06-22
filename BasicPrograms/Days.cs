using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Days
    {
        public void Year()
        {
            int days,week,years;
            Console.WriteLine("Enter the days");
            days=Convert.ToInt32(Console.ReadLine());
             years = days / 365;
            Console.WriteLine("The days in Years is " + years);
            week=days / 7;
            Console.WriteLine("The days in weeks is " + week);
        }
    }
}
