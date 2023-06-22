using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class DataType
    {
        public void Size()
        {
           //Sizes of data types
            Console.WriteLine("Size of integer :" + sizeof(int));
            Console.WriteLine("Size of Char :" + sizeof(char));
            Console.WriteLine("Size of Float :" + sizeof(float));
            Console.WriteLine("Size of Double :" + sizeof(double));
            Console.WriteLine("Size of Boolean :" + sizeof(bool));
            Console.WriteLine("Size of Long :" + sizeof(long));
            Console.WriteLine("Size of Short  :" + sizeof(short));


        }
    }
}
