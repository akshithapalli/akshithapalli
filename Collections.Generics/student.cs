using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Generics
{
    class student
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Example of List");
            List<string> list = new List<string>();
            Console.WriteLine("Please enter name of languages");
            for (int i = 1; i < 3; i++)
                //clear all data in the list
                //list.Clear();
                list.Sort();
            Console.WriteLine("After Sorting of List");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //this will help us to find some value or search value in list
            bool flag = list.Contains(9);
            if (flag)
            {
                Console.WriteLine("We are able to find 9 in the list");
            }
            else
            {
                list.Add(Console.ReadLine());
                Console.WriteLine(" 9 was not there in the list");
            }
           list.Remove(0);
            list.RemoveAt(1);
            Console.WriteLine("After removal of items from List");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

    }
}
