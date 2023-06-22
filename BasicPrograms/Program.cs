using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Programs");
            while (true) 
            {
                Console.WriteLine("\n");
                Console.WriteLine("1-DataType Size");
                Console.WriteLine("2-Swaping Values");
                Console.WriteLine("3-ASCII values");
                Console.WriteLine("4-Arthimatic Operations");
                Console.WriteLine("5-Area of Circle");
                Console.WriteLine("6-Convert days to years and weeeks");
                Console.WriteLine("CHOOSE THE ABOVE OPTION");

                int option =Convert.ToInt32(Console.ReadLine());
                switch(option) 
                {
                    case 1: Console.WriteLine("Sizes of some datatypes");
                        DataType dataType=new DataType();
                        dataType.Size();
                        break;
                    case 2:
                        Console.WriteLine("Swaping two values");
                        Swap swap=new Swap();
                        swap.Number();
                        break;
                        case 3:
                            Console.WriteLine("ASCII value");
                            ASCII aSCII=new ASCII();
                            aSCII.Values();
                        break;
                    case 4:
                        Console.WriteLine("Arthimatic operations");
                        Arthimatic arthimatic=new Arthimatic();
                        arthimatic.Operation(40,20);
                        break;
                    case 5:
                        Console.WriteLine("Area of circle");
                        Areaof areaof=new Areaof();
                        areaof.Circle();
                        break;
                    case 6:
                        Console.WriteLine("Convert days");
                        Days days=new Days();
                        days.Year();
                        break;
                    default: Console.WriteLine("Invalid option");
                        break;
                        
                }
            }
        }
    }
}
