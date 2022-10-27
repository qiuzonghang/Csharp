// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace ThtreeDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入个人信息");
            string name = Console.ReadLine();
            var nameList = name.Split(',');
            Console.WriteLine("你的姓名：{0}", nameList[0]);
            Console.ReadKey();
        }
    }
}