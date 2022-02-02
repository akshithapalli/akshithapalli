using System;
using System.Collections.Generic;
using System.Text;

namespace oopconcept
{
    class instancevar
    {
        //local static instance variable
        public int sampleInstanceVariable;
        public void display()
        {
            int localVal = 5;
            Console.WriteLine(localVal);
        }
        static void Main6(string[] args)
        {
            instancevar Obj1 = new instancevar();
            Obj1.sampleInstanceVariable = 5;
           instancevar  Obj2 = new instancevar();
            Obj2.sampleInstanceVariable = 6;
            Console.WriteLine(Obj1.sampleInstanceVariable);
            Console.WriteLine(Obj2.sampleInstanceVariable);
            Obj1.display();
            Obj2.display();
        }
    }
}
