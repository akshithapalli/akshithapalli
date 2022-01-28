using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("enter values here");
              int a = Convert.ToInt32(Console.ReadLine());
              int b= Convert.ToInt32(Console.ReadLine());
               if (a> b)
               {
                   Console.WriteLine(" a is greater than b");
               }
               else
               {
                   Console.WriteLine("b is greater than a");
               }*/

            /*Console.WriteLine("enter values here");
            int number1=Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine(" after swapping");
            Console.WriteLine("number1="+number1);
            Console.WriteLine("number2="+number2);
            */
            /*Console.WriteLine("enter values here");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >=18 && age <60 )
            {
                Console.WriteLine("able to vote=" + age);
            }
            else if ( age >60)
            {
                Console.WriteLine("senior citizen=" + age);
            }
            else
            {
                Console.WriteLine("unable to vote="+age);
            }*/
            Console.WriteLine("Calculator");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.Write("Enter Choice(1-4):");
            int ch = Int32.Parse(Console.ReadLine());
            int a, b, c;
            switch (ch)
            {
                case 1:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Sum = {0}", c);
                    break;
                case 2:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Difference = {0}", c);
                    break;
                case 3:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Product = {0}", c);
                    break;
                case 4:
                    Console.Write("Enter A:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Quotient = {0}", c);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
        }
    }
}
 