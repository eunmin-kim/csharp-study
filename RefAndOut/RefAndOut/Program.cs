using System;

namespace RefAndOut
{
    internal class Program
    {
        /// <summary>
        /// 변수를 꼭 초기화 해줘야하고 참조형태로 매개변수로 넘겨줌
        /// </summary>
        /// <param name="num"></param>

        public static void UpdateRefValue(ref int num)
        {
            num = 5;
        }
        
        /// <summary>
        /// ComputeSquares 메소드는 입력된 숫자 number에 대해 제곱(square)과 제곱근(squareRoot)을 계산하여 각각 out 매개변수를 통해 반환합니다. out 매개변수는 메소드 안에서 반드시 값을 할당받아야 합니다.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="square"></param>
        /// <param name="squareRoot"></param>

        public static void ComputedSquare(int number, out int square, out double squareRoot)
        {
            square = number * number;
            squareRoot = Math.Sqrt(number);
        }
        
        
        /// <summary>
        /// 변수를 초기화 할 필요 없지만 메서드 내에서는 반드시 할당 해야함
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        public static void GetValues(out int value1, out int value2)
        {
            value1 = 10;
            value2 = 20;
        }
        public static void Main(string[] args)
        {
            /**
             * Out 예제
             */
            // int a,b;
            GetValues(out int value1, out int value2);
            Console.WriteLine($"Out : {value1} {value2}");
            
            /**
             * ref 예제
             */
            int refA = 1;
            
            UpdateRefValue(ref refA);
            Console.WriteLine($"Ref : {refA}");
            
            
            /**
             * Out 예제 2
             */
            int size = 10;

            ComputedSquare(size,out int square , out double squareRoot);
            Console.WriteLine($"ComputedSquare : size={size} square={square} squareRoot={squareRoot}");
        }
    }
}