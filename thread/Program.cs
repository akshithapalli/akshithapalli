using System;
using System.Threading;


namespace thread
{
    class Program
    {
        internal class ExampleofThreadJoin
        {
            static void Main(string[] args)
            {
                Thread thread = new Thread(MethodJoin);
                Console.WriteLine(thread.ThreadState);
                thread.Start();
                Console.WriteLine(thread.ThreadState);
                thread.Join();
                Console.WriteLine(thread.ThreadState);
                Console.WriteLine("Work completed");
            }

            static void MethodJoin()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Work in progress");
                }
            }
        }
    }
}
