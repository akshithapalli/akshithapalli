using System;
using System.Text.RegularExpressions




  namespace specialcharacterexception
{
    class Program
    {
        static void Main(string[] args)
        {
                public class SpecialCharacterException : Exception
        {
            public SpecialCharacterException(string message) : base(message)
            {



            }
        }
    }
}


        public class SpecialCharacter
        {
            String s = "[^a-zA-Z0-9]+";


            public void ShowCharac()
            {
                Regex r = new Regex(s);
                if (s == null)
                {
                    Console.WriteLine("String is Null");
                    return;
                }
                MatchCollection m = r.Matches(s);
                if (m.Count != 0)
                    throw (new SpecialCharacterException("Special Character found"));
                else
                    Console.WriteLine("Special Character {0} :", s);
            }
            static void Main(string[] args)
            {

                SpecialCharacter sc = new SpecialCharacter();
                try
                {
                    sc.ShowCharac();
                }
                catch (SpecialCharacterException e)
                {
                    Console.WriteLine("Custom execption is {0}", e.Message);
                }
            }
        }
   