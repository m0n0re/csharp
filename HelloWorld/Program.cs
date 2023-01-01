using System;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Srart");

            // 文字入力を読み取るにはConsole.ReadLine()を使う
            String str = Console.ReadLine();

            // 入力された文字列を表示
            Console.WriteLine("str = {0}", str);

            // var：型推論
            // varは型推論なので右辺がないとコンパイルエラーがでる
            //var x;
            var x1 = 1;

            // タプル c# 7.0で追加
            // https://ufcpp.net/study/csharp/datatype/tuples/
            var (x2, y2) = (1, 2);

            // システムで予約されている単語は変数名に使えないが@をつけると使える(逐次的識別子)
            var @for = "for";
            var @this = "this";

            {
                //括弧でくくるとブロック化できるらしい
                string hello = "hello";
                string bye = "bye!";
            }


            Console.WriteLine("Program end.");
        }
    }
}
