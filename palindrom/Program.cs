using System;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, sum = 0, temp;
            Console.WriteLine("ENTER THE NUMBER");
            int n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("NUMBER IS PALINDROME" + n);
            else
                Console.WriteLine("NUMBER IS NOT PALINDROME" + n);
        }
    }
}
