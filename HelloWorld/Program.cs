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
            // String str = Console.ReadLine();

            // 入力された文字列を表示
            Console.WriteLine("str = {0}");

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

            // 組み込み型の種類
            // 単純型
            // 整数型
            byte tByte = 0;     // 8ビット整数 0 ～ 255
            short tShort = 0;   // 16ビット整数 -32,768 ～ 32,767
            ushort tUshort = 0; // 符号なし 0 ～ 65,535
            int tInt = 0;       // 32ビット整数 -2,147,483,648 ～ 2,147,483,647
            long tLong = 0;     // 64ビット整数 -9,223,372,036,854,775,808 ～ 9,223,372,036,854,775,807

            char tChar = 'a';   // 文字型

            float tFloat = 0.1f;    // 浮動小数点型 単精度
            double tDouble = 0.1D;  // 浮動小数点型 倍精度
            decimal tDecimal = 0.01M; // デシマル型

            bool tBool = true;  // 論理型

            string tStr = "string"; //文字列型
            Object tObj = new Object(); // オブジェクト型

            // エスケープシーケンス

            char tChar2 = '\''; // シングルクォート
            string tStr2 = "\""; // ダブルクォーテーション
            string tStr3 = "\\"; // バックスラッシュを文字列として使う



            Console.WriteLine("Program end.");
        }
    }
}
