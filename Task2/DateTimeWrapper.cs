using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DateTimeWrapper
    {
        public DateTime storedDateTime { get; }
        public bool IsTimeInFuture { get; } = false;
        public int SumOfDigits = 0;

        public DateTimeWrapper(DateTime dateTime)
        {
            storedDateTime = dateTime;
            if (DateTime.Now < dateTime)
            {
                IsTimeInFuture = true;
            }
            calculateSumOfDigits();
        }
        public void calculateSumOfDigits()
        {
            SumOfDigits = calculateSumOfDigitsInNumber(storedDateTime.Year) + calculateSumOfDigitsInNumber(storedDateTime.Month) + calculateSumOfDigitsInNumber(storedDateTime.Day) + calculateSumOfDigitsInNumber(storedDateTime.Hour) + calculateSumOfDigitsInNumber(storedDateTime.Minute) + calculateSumOfDigitsInNumber(storedDateTime.Second);
        }
        public int calculateSumOfDigitsInNumber(int num)
        {
            int sum = 0;
            while (num >= 10)
            {
                sum += (num % 10);
                num /= 10;
            }
            sum += num;
            return sum;
        }
        public bool Compare(DateTimeWrapper obj)
        {
            if (this.SumOfDigits > obj.SumOfDigits)
            {
                return true;
            }
            return false;
        }
    }
}
