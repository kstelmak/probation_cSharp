using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyClass
    {
        public DateTime myDateTime { get; set; }
        public bool IsTimeInFuture = false;
        public int SumOfDigits = 0;
        public MyClass(DateTime dt)
        {
            myDateTime = dt;
            if (DateTime.Now < dt)
            {
                IsTimeInFuture = true;
            }
            SumOfDigits = myDateTime.Year + myDateTime.Month + myDateTime.Day + myDateTime.Hour + myDateTime.Minute + myDateTime.Second;
        }
        public bool Compare(MyClass obj)
        {
            if (this.SumOfDigits > obj.SumOfDigits)
            {
                return true;
            }
            return false;
        }
        public void getInfo()
        {
            Console.WriteLine($"{this.myDateTime.Year} {this.myDateTime.Month} {this.myDateTime.Day} {this.myDateTime.Hour} {this.myDateTime.Minute} {this.myDateTime.Second}");
            if (this.IsTimeInFuture)
            {
                Console.WriteLine("Is In Future");
            }
            else
            {
                Console.WriteLine("Isn't In Future");
            }
            Console.WriteLine($"Sum of digits = {this.SumOfDigits}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass(new DateTime(2022, 07, 14, 15, 58, 10));
            MyClass obj2 = new MyClass(new DateTime(2033, 03, 03, 03, 33, 33));

            obj1.getInfo();
            obj2.getInfo();
                        
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
