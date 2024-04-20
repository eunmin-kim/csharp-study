using System;
using System.Collections.Generic;


namespace FuncDelegateExample
{
    /// <summary>
    /// Func Delegate 를 이용한 리스트 필터링
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> evenNumbers = Filter(numbers, x => x % 2 == 0);

            Console.Write("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.Write($" {number}");
            }
        }


        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Func<T, bool> filter)
        {
            foreach (var item in items)
            {
                if (filter(item) == true)
                {
                    yield return item;
                }
            }
        }
    }
}