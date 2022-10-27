// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace TwoDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 100;
            int n2 = 50;
            n1 = n1 - n2;
            n2 = n2 + n1;
            n1 = n2 - n1;
            Console.WriteLine("n1:{0}\nn2:{1}",n1,n2);
            Console.ReadKey();
        }
    }
}