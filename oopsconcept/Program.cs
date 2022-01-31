using System;

namespace oopsconcept
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            Console.WriteLine(" Previous value of index" + index.ToString());
            string result = GetNameValue(out index);
            Console.WriteLine(" current value of index" + index.ToString());

            static string GetNameValue(out int id)
            {
                id = 1;
                string returnText = " DummyName" + id.ToString();
                id += 1;
                return returnText;
            }
        }
    }
}
