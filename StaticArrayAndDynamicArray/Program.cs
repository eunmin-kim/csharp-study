using System;
using System.Collections.Generic;

namespace StaticArrayAndDynamicArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /**
             * 정적 배열
             * 배열의 크기가 선언시에 고정됨
             */
            int[] numbers = new int[5]{1,2,3,4,5};

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
            
            /**
             * 동적 배열
             * 크기가 동적으로 변경될 수 있음
             */

            List<int> numsList = new List<int>() { 1, 2, 3, 4, 5 };

            foreach (int num in numsList)
            {
                Console.Write($"{num} ");
            }
        }
    }
}