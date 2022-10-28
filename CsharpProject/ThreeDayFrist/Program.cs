// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace ThreeDayFrist
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tshirt = 35;
            int trousers = 120;
            Console.WriteLine("小明共花费：{0}，打8.8折后为：{1}", Tshirt * 3 + trousers * 2, (Tshirt * 3 + trousers * 2) * 0.88);
            Console.ReadKey();
        }
    }
}