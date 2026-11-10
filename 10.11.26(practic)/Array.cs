using System;
using System.Collections.Generic;
using System.Text;

namespace _10._11._26_practic_
{
    internal class Array
    {
        public void Save()
        {
            Random random = new Random();

            string even = " ";
            string odd = " ";

            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0;i < 10000;i++)
            {
                int number = random.Next(1, 10001);

                if(number % 2  == 0 )
                {
                    even += number + "\n";
                    evenCount++;
                }
                else
                {
                    odd += number + "\n";
                    oddCount++;
                }
               
            }
            File.WriteAllText("even.txt", even);
            File.WriteAllText("odd.txt", odd);

            Console.WriteLine($"Even numbers:{evenCount}");
            Console.WriteLine($"Odd numbers:{oddCount}");

        }
    }
}
