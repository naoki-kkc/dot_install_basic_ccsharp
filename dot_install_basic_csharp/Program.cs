using System;

namespace dot_install_basic_charp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* lesson 04 */
            /*
            // 変数
            string msg_val;
            msg_val = "hoge";
            Console.WriteLine(msg_val);

            msg_val = "fuga"; // 再代入可能
            Console.WriteLine(msg_val);

            // 定数
            const string msg_const = "foo";
            Console.WriteLine(msg_const);

            // 確認する場合はコメントアウトを外す
            // msg_const = "bar"; // <- 定数は再代入できないのでエラーとなる
            // Console.WriteLine(msg_const);
            */

            /* lesson 05 */
            /*
            // よく使われる型
            string  str = "string"; // 文字列
            char    c   = 'c';      // 文字
            int     i   = 100;      // 整数値
            double  d   = 1.234;    // 浮動小数点数
            float   f   = 2.34f;    // 浮動小数点数(最後にfをつける)
            bool    b   = true;     // 論理値型

            //型推論 - varを使った変数宣言
            var x = "string";               // 文字列を代入
            Console.WriteLine(x.GetType()); // -> System.String
            var y = 1;                      // 整数値を代入
            Console.WriteLine(y.GetType()); // -> System.Int32
            }/

            /* lesson 06 */
            var x = 10;
            Console.WriteLine(x + 3);   // 加
            Console.WriteLine(x - 3);   // 減
            Console.WriteLine(x * 3);   // 積
            Console.WriteLine(x / 3);   // 割
            Console.WriteLine(x / 3.0);   // 割(浮動小数点数その1)
            Console.WriteLine(x / (double)3);   // 割(浮動小数点数その2)
            Console.WriteLine(x % 3);   // 余り

            var y = 5;
            y++;
            Console.WriteLine(y);   // インクリメント
            y = 5;
            y--;
            Console.WriteLine(y);   // デクリメント

            var z = 10;
            z += 5; // z = z + 5 と等価

            var flag = true;
            Console.WriteLine(flag);
            Console.WriteLine(!flag); // 論理値の反転



        }
    }
}
