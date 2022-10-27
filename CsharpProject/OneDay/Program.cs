// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace OneDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mimir";
            int age = 18;
            char gender = '男';
            double heiht = 170.9;
            decimal money = 10000m;
            Console.WriteLine("我叫{0}，我今年{1}歲，我是{2}的，我身高{3}，工資{4}。", name, age, gender, heiht, money);
            Console.ReadKey();
        }
    }
}