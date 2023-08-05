using System;
using System.Linq;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter :");
            string input = Console.ReadLine();
            var sss = input.ToList();
            int count = 0;
            bool reault = false;
            if (sss[0] == ')')
                reault = false;
            foreach (var item in sss)
            {
                if (item == '(')
                {
                    count++;
                }
                else if (item == ')')
                {
                    count--;
                }
                if (count < 0)
                {
                    break;
                }
            }
            if (count == 0)
            {
                reault = true;
                Console.WriteLine(reault);
            }
            else
                Console.WriteLine(reault);
        }
    }
}
