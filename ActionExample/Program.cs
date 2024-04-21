
namespace ActionExample;

class Program
{
    static void Main(string[] args)
    {

        // 파라미터가 없는 Action
        Action printHello = () => Console.WriteLine("Hello, Action!");
        printHello();
        
        // 파라미터가 있는 Action

        Action<int, int> printSum = (int a, int b) => Console.WriteLine($"Sum Result: {a + b}");
        printSum(1, 2);
    }
}