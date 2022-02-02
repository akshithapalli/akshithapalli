using System;
using System.Collections.Generic;
using System.Text;

namespace oopconcept
{
     public class constructor
    {
        int a, b;
     public constructor()
        {

        }
        ~constructor()
        {

        }
        public constructor(int _a,int _b)
        {
            a = _a;
            b = _b;

        }
    }
    class constructorvsdestructor
    {
         public static void Main1(string[] args)
        {
            constructor Objconstructor = new constructor();
            Console.ReadLine();
        }
        class CallContructorAndDescructor
        {
            CallContructorAndDescructor()
            {
                Console.WriteLine("Constructor is getting called");
            }
            ~CallContructorAndDescructor()
            {
                Console.WriteLine("Descructor is getting called");
                Console.ReadLine();
            }
            static void main (string[] args)
            {
                CallContructorAndDescructor s = new CallContructorAndDescructor();
                Console.WriteLine();
            }
        }
    }
}
