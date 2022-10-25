// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace MyVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; //声明int类型变量
            number = 100;   //给变量赋值

            int number1 = 1000; //上方两行代码简写
            double number2 = 1.21; //小数定义，double也可以定义整数，小数点后15~16位
            string username = "张三"; //定义字符串，可定义为空
            char gender = '男';  //定义字符，单引号，只能定义一个字符且不可为空
            decimal money = 10002.212m; //定义金额
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(username);
            Console.WriteLine(gender);
            Console.WriteLine(money);
            Console.ReadKey();
        }
    }
}
