using System;

namespace exercise
{
    class Program
    {

        public static void Main1()
        {
            string str;
            int i, len, vow, cons;
            Console.Write("\n\nCount total number of vowel or consonant :\n");
            Console.Write("Enter the string \n ");
            str = Console.ReadLine();
            vow = 0;
            cons = 0;
            len = str.Length;
            for (i = 0; i < len; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vow++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    cons++;
                }
            }
            Console.Write("\nThe total number of vowel in the string is : {0}\n", vow);
            Console.Write("The total number of consonant in the string is : {0}\n\n", cons);
        }
    }
}

