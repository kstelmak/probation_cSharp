using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static void getInfo(DateTimeWrapper obj)
        {
            Console.WriteLine($"{obj.storedDateTime.Year} {obj.storedDateTime.Month} {obj.storedDateTime.Day} {obj.storedDateTime.Hour} {obj.storedDateTime.Minute} {obj.storedDateTime.Second}");
            if (obj.IsTimeInFuture)
            {
                Console.WriteLine("Is In Future");
            }
            else
            {
                Console.WriteLine("Isn't In Future");
            }
            Console.WriteLine($"Sum of digits = {obj.SumOfDigits}");
        }
        static void Main(string[] args)
        {
            DateTimeWrapper obj1 = new DateTimeWrapper(new DateTime(2022, 07, 14, 15, 58, 10));
            DateTimeWrapper obj2 = new DateTimeWrapper(new DateTime(2033, 03, 03, 03, 33, 33));

            getInfo(obj1);
            getInfo(obj2);
                        
            if (obj1.Compare(obj2))
            {
                Console.WriteLine($"Sum of digits of obj1 is bigger than sum of obj2");
            }
            else
            {
                Console.WriteLine($"Sum of digits of obj1 isn't bigger than sum of obj2");
            }

            Console.ReadKey();
        }
    }
}
