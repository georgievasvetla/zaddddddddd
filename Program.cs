using System.Diagnostics.CodeAnalysis;

namespace zadNok
{
    internal class Program
    {
        static int NOD(int a,int b)
        {
            return b == 0 ? a : NOD(b, a % b);
        }
        static int NOK(int a,int b)
        {
            return a * (b / NOD(a, b));
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int nok=NOK(a,b);
            Console.WriteLine(nok);
        }
    }
}