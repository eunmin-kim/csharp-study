using System;
using System.Threading.Tasks;

namespace TaskExample
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            Task<int> logRunningTask = new Task<int>(() => CalculateData());
            Console.WriteLine("다른 작업 수행 중...");
            int result = await logRunningTask;

            Console.WriteLine($"결과: {result}");

        }

        private static int CalculateData()
        {
            // 복잡한 계산을 가정
            System.Threading.Thread.Sleep(2000); // 시뮬레이션을 위한 딜레이
            return 123;
        }
    }
}