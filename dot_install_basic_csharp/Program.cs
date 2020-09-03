using System;

namespace dot_install_basic_charp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* lesson 04 */
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
            

        }
    }
}
