using System;
using System.Linq;
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


            // 数字
            // 数字区切り文字 アンダーバーで数値を区切れる
            var million = 1_000_000;
            var kugiri1 = 1.123_456_789;

            // 文字列
            // 文字列補間
            var formatted = string.Format("({0},{1})", "a", "b");
            // ↑ めんどい！
            // ↓ Format用専用構文が追加された！補間文字列(or文字列補間)という。
            var formatted2 = $"{tStr2},{tStr3}";

            // 補完文字列は書式指定もできる
            var formatted3 = $"({12300:c}, {12300:n}, {12300,4:x})"; // → (¥12,300, 12,300.00, 300c)

            Console.WriteLine(formatted3);

            // 補完文字列は色々な式が書ける
            var data = new[] { 1, 2, 3 };
            var s = $"{string.Join(", ", data)} => {string.Join(", ", data.Select(i => i * i))}";

            // string.Join(", ", data) は data 配列の中身を , で結合して出力
            // string.Join(", ", data.Select(i => i * i)) は 配列の中身を取り出して i とする。 i * i の結果を出力する
            Console.WriteLine(s); // 1, 2, 3 => 1, 4, 9 という文字列が出力

            // $@と書くことで複数行の補完文字列にすることもできる ただしエスケープのバックスレッシュは使えない
            var hokan = $@"
                verbatim (here) string
                {tStr},{tStr2},{tStr3}
            ";

            // name of 演算子
            // name ofを使うことでClassやMethodなどの名前を文字として取得することができる
            var name1 = nameof(Program);
            Console.WriteLine(name1); // -> Program

            // https://ufcpp.net/study/csharp/st_string.html?p=2
            // 生成文字リテラル

            // var tStr4 = """ aaa """;

            // 算術演算子

            byte a = 11 + 92; // 103
            int b = 9 - 4; // 5
            int c = 3 * 7; // 21
            int d = 9 / 2; // 4 (あまりは切り捨て)
            double e = 9.0 / 2.0; // 4.5
            int f = 9 % 2; // 1 (あまりを算出)
            int g = +1; // 1をそのまま
            int h = -g; // gの符号反転（マイナス)

            // インクリメント デクリメント

            // 前置きインクリメント
            int i0 = 0;
            int i2 = ++i0; // i2 は 1, i0 も1 になる

            // 後置きインクリメント
            int i3 = 0;
            int i4 = i3++; // i4は1、i3は0；

            // 前置きデクリメント
            int i5 = 0;
            int i6 = --i5; // i6とi5は-1になる

            // 後置きデクリメント
            int i7 = 0;
            int i8 = i7--; // i8は-1,i7 は 0 になる

            // 複合代入
            // += -= *= /= &= |= ^= 
            // a += 1 は aに+1したものが代入される。他も同じ

            // null 合体演算子??

            string str1 = null;
            string str2 = str1 ?? "null"; // param1がnullなら文字列”null”をセットする

            // C#8から合体代入もできる
            // string str1 ??= "null";

            // size of 演算子
            // size of は型が何バイトのメモリを占めるかを返す
            // int なら　4バイト、byteなら1バイト。


            Console.WriteLine("Program end.");
        }
    }
}
