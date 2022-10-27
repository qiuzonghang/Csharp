// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace OneDayFrist
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 100.322;
            double n2 = 20;
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;
            Console.WriteLine("n1:{0}\nn2:{1}", n1, n2);
            Console.ReadKey();
        }
    }
}