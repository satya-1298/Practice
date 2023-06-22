using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public  class Arthimatic
    {
        public void Operation(int a,int b)
        {
            //Addition
            int add = a + b;
            Console.WriteLine("Addition of two numbers"+ add);
            //Subtration
            int sub = a - b;
            Console.WriteLine("Subtraction of two numbers" + sub);
            //Multiplication
            int mul = a * b;
            Console.WriteLine("Multiplication of two numbers" + mul);
            //Division
            int div=a / b;
            Console.WriteLine("Division of two numbers" + div);
            //Modulo
            int mod=a % b;
            Console.WriteLine("Remainder of two numbers" + mod);




        }
    }
}
