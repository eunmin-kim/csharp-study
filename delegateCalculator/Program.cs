using System;

namespace delegateCalculator
{

    /// <summary>
    /// 델리게이트 정의
    /// </summary>
    public delegate double MathOperation(double x, double y);
    
    
    
    /// <summary>
    /// 델리게이트를 활용한 계산기 프로그램
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {

            Calculator calculator = new Calculator();
            MathOperation op;

            op = calculator.Add;
            Console.WriteLine($"Add: {op(10,5)}");

            op = calculator.Divide;
            Console.WriteLine($"Divide: {op(10,5)}");
        }
    }
}