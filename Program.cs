﻿using System;

namespace equal_and___
{
    class Program
    {
        static void Main1(string[] args)
        {

            string name = "akshitha";
            string Myname = name;
            var doubleeql = (name == Myname);
            var eql = name.Equals(Myname);
            Console.WriteLine(doubleeql);
            Console.WriteLine(eql);
            object nameObj = " akshitha";
            char[] values = { 'a', 'k', 's', 'h', 'i', 't', 'h', 'a' };
            object myName = new string(values);
            var doubleeql2 = (nameObj == myName);
            var eql2 = nameObj.Equals(myName);
            Console.WriteLine(doubleeql2);
            Console.WriteLine(eql2);
        }
    }
}
