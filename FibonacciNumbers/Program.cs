namespace FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fibonacci = fib(n-1) + fib(n-2)
            int a = 0, b = 1, c;
            Console.WriteLine("Enter a number please:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nResult:");
            Console.WriteLine("\n" + a + "\n\n" + b + "\n");
            for(int i = 2; i<=n; i++)
            {
                c = a + b;
                Console.WriteLine(c + "\n");
                a = b;
                b = c;
            }
        }
    }
}
