using System;

namespace sealedclasses
{
    sealed class A
    {
public int Add(int a,int b)
        {
            return a + b;
        }

    }
    class Program
    {
        static void Main1(string[] args)
        {

            A a = new A();
            int c=a.Add(1, 2);
            Console.WriteLine("Add:{0}",+c);
        }
    }
}
