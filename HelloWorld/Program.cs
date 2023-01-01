using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Srart");

            //文字入力を読み取る
            String str = Console.ReadLine();

            //入力された文字列を表示
            Console.WriteLine("str = {0}", str);

            Console.WriteLine("Program end.");
        }
    }
}
