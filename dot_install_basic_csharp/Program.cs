using System;
using System.Threading.Tasks.Sources;
// using Lesson26Namespace1;

namespace dot_install_basic_charp
{
    // デリゲート：メソッドを割り当てることができる変数
    delegate void MyDelegate();
    delegate void MyDelegateMulti();

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
            /*
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
            */

            /* lesson 07 */
            /*
            Console.WriteLine("hello " + "world");          // 文字列結合
            Console.WriteLine("hello " + "\n" + "world");   // 特殊文字

            // string.Formatを使用した代入
            Console.WriteLine(string.Format("{0} - {1}", "first", "secont"));
            */

            /* lesson 08 */
            /*
            var num = int.Parse(Console.ReadLine()); // 入力文字列を整数にパース(エラー処理は除いて簡素化)
            if (num > 80)
            {
                Console.WriteLine("Great");
            }
            else if (num > 60)
            {
                Console.WriteLine("Good");
            }
            else {
                Console.WriteLine("so so");
            }
            Console.WriteLine("-------------------");
            Console.WriteLine((num > 80) ? "great" : "hoge");
            */

            /* lesson 09 */
            /*
            var signal = Console.ReadLine();
            switch (signal) {
                case "red":
                    Console.WriteLine("Stop");
                    break;
                case "green":
                case "blue":
                    // green または blueで実行
                    Console.WriteLine("Go");
                    break;
                case "yellow":
                    Console.WriteLine("Caution");
                    break;
                default:
                    Console.WriteLine("wrong signal");
                    break;
            }
            */

            /* lesson 10 */
            /*
            var i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);   // show 0 to 9
                i++;
            }

            Console.WriteLine("---------------");
            var j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 10);
            */

            /* lesson 11 */
            /*
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue; // 5を出力しない
                }

                if (i == 8)
                {
                    break; // 8でループを抜ける
                }

                Console.WriteLine(i);

            }
            */

            /* lesson 12 */
            /*
            int[] scores = new int[3];
            scores[0] = 10;
            scores[1] = 20;
            scores[2] = 30;
            Console.WriteLine(scores[1]); // 20
            
            int[] scores2 = { 10, 20, 30 };
            Console.WriteLine("diff score2 [0] = " + (scores[0] == scores2[0]));
            Console.WriteLine("diff score2 [1] = " + (scores[1] == scores2[1]));
            Console.WriteLine("diff score2 [2] = " + (scores[2] == scores2[2]));

            var scores3 = new[] { 10, 20, 30 };
            Console.WriteLine("diff score3 [0] = " + (scores[0] == scores3[0]));
            Console.WriteLine("diff score3 [1] = " + (scores[1] == scores3[1]));
            Console.WriteLine("diff score3 [2] = " + (scores[2] == scores3[2]));
            */

            /* lesson 13 */
            /*
            var scores = new[] {10, 20, 30 };
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }

            foreach (var score in scores)
            {
                Console.WriteLine(score);
            }
            */

            /* lesson 14 */
            /*
            FuncLesson14_1();
            Console.WriteLine(FuncLesson14_2());
            Console.WriteLine(FuncLesson14_2_re());
            */

            /* lesson 15 */
            /*
            FuncLesson15_1("Mike");
            FuncLesson15_2("George", 20);           // 引数の通りに渡す
            FuncLesson15_2(age: 20, name: "Steve"); // 引数を変数名付きで渡す
            */

            /* lesson 16 */
            /*
            // 変数(フィールド)とメソッドを持ったクラス
            Lesson16User user = new Lesson16User();
            user.SayHi();       // => hi hoge
            user.name = "fuga";
            user.SayHi();       // => hi fuga
            */

            /* lesson 17 */
            /*
            Lesson17User user = new Lesson17User();
            user.SayHi();       // => hi foo
            Lesson17User user2 = new Lesson17User("Tom");
            user2.SayHi();      // => hi Tom
            */

            /* lesson 18 */
            /*
            Lesson18UserChild userC = new Lesson18UserChild("Bob");
            userC.SayHi();
            userC.SayHello();
            */

            /* lesson19 */
            /*
            Lesson19User user = new Lesson19User();
            user.Showattrs();
            Console.WriteLine(user.public_str);
            // Console.WriteLine(user.protected_str); // 継承していないクラスからは見えないのでコンパイルエラー
            // Console.WriteLine(user.private_str);   // privateなのでコンパイルエラー

            Lesson19UserChild userc = new Lesson19UserChild();
            userc.ShowattrsC();
            */

            /* lesson20 */
            /*
            Lesson20User user = new Lesson20User();
            user.Name = "";
            Console.WriteLine(user.Name);
            user.Name = "fuga";
            Console.WriteLine(user.Name);
            */

            /* lesson21 */
            /*
            Lesson21Bean bean = new Lesson21Bean();
            bean[0] = "hoge";
            bean[1] = "fuga";
            bean[2] = "foobar";
            Console.WriteLine(bean[0]);
            Console.WriteLine(bean[1]);
            Console.WriteLine(bean[2]);

            // 配列の長さが3なので、以下はエラーとなる
            // bean[3] = "piyo";
            // Console.WriteLine(bean[3]);
            */

            /* lesson22 */
            /*
            Lesson22User.ShowCount();
            Lesson22User user = new Lesson22User();
            Lesson22User user2 = new Lesson22User();
            Lesson22User user3 = new Lesson22User();
            Lesson22User.ShowCount();
            */

            /* lesson23 */
            /*
            Lesson23User taro = new Lesson23Japanese();
            Lesson23User naomi = new Lesson23American();
            taro.SayHi();
            naomi.SayHi();
            */

            /* lesson24 */
            /*
            Lesson24User user = new Lesson24User();
            user.Share();
            */

            /* lesson25 */
            /*
            Lesson25MyInteger itgr = new Lesson25MyInteger();
            itgr.ShowThreeTime(10);

            Lesson25MyData<string> mystr = new Lesson25MyData<string>();
            mystr.ShowThreeTime("hello");
            Lesson25MyData<int> myint = new Lesson25MyData<int>();
            myint.ShowThreeTime(10);
            Lesson25MyData<double> mydouble = new Lesson25MyData<double>();
            mydouble.ShowThreeTime(2.2);
            */

            /* lesson26 */
            /*
            User user_ns1 = new User();
            user_ns1.Say();

            Lesson26Namespace2.User user_ns2 = new Lesson26Namespace2.User();
            user_ns2.Say();
            */

            /* lesson27 */
            /*
            // 構造体 - クラスと似ているが継承ができない
            Point p1 = new Point(1, 2);
            p1.GetInfo();
            Point p2 = new Point(4, 8);
            p2.GetInfo();
            */

            /* lesson28 */
            /*
            // 列挙型
            Lesson28Direction direction = Lesson28Direction.Right;
            Console.WriteLine(direction);

            switch (direction)
            {
                case Lesson28Direction.Stay:
                    Console.WriteLine("Stay selected");
                    break;
                case Lesson28Direction.Right:
                    Console.WriteLine("Right selected");
                    break;
                case Lesson28Direction.Left:
                    Console.WriteLine("Left selected");
                    break;
            }

            Lesson28DirectionByNum directionBn = Lesson28DirectionByNum.Right;
            Console.WriteLine((int)directionBn);
            */

            /* lesson29 */
            /*
            Lesson29Div(1, 2);
            Lesson29Div(1, -2);
            */


            /* lesson30 */
            // デリゲートがあることで戻り値の変数にメソッドを仕込むことができる
            MyDelegate myDelegate = Lesson30SayHi;
            myDelegate();

            Console.WriteLine("---");

            // マルチキャストデリゲート:一つのデリゲートに複数のメソッドを割り当てる
            MyDelegateMulti myDelegateMulti = Lesson30SayHi;
            myDelegateMulti += Lesson30SayGoodbye;
            myDelegateMulti();

        }

        /*
        static void FuncLesson14_1()
        {
            Console.WriteLine("hello");
        }

        static string FuncLesson14_2()
        {
            return "hi";
        }

        static string FuncLesson14_2_re() => "hi!";
        */

        /*
        static void FuncLesson15_1(string name)
        {
            Console.WriteLine($"hi, {name}");
        }

        static void FuncLesson15_2(string name, int age)
        {
            Console.WriteLine($"hello, {name}({age})");
        }
        */

        /*
        static void Lesson29Div(int a, int b)
        {
            try
            {
                if (b < 0)
                {
                    // 何らかの例外を発生させたい状況とする
                    throw new Lesson29Exception("b : minus val is not support");
                }
                Console.WriteLine(a / b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        */

        static void Lesson30SayHi()
        {
            Console.WriteLine("hi!");
        }

        static void Lesson30SayGoodbye()
        {
            Console.WriteLine("goodbye...");
        }

    }


    /*
    class Lesson16User
    {
        public string name = "hoge";
        public void SayHi() {
            // Console.WriteLine($"hi {this.name}");
            Console.WriteLine($"hi {name}");
        }
    }
    */

    /*
    class Lesson17User
    {
        public string name = "hoge";
        // public Lesson17User()
        // {
        //     this.name = "foo";
        // }
        public Lesson17User() : this("foo") { } // 「this("foo")」で「Lesson17User("foo")」を呼び出したことになる
        public Lesson17User(string name)        // コンストラクタのオーバーロード
        {
            this.name = name;
        }
        public void SayHi()
        {
            // Console.WriteLine($"hi {this.name}");
            Console.WriteLine($"hi {name}");
        }
    }
    */

    /*
    class Lesson18User
    {
        public string name = "hoge";
        public Lesson18User() : this("foo") { } // 「this("foo")」で「Lesson17User("foo")」を呼び出したことになる
        public Lesson18User(string name)        // コンストラクタのオーバーロード
        {
            this.name = name;
        }
        public virtual void SayHi()
        {
            // Console.WriteLine($"hi {this.name}");
            Console.WriteLine($"hi {name}");
        }
    }

    class Lesson18UserChild : Lesson18User
    {
        public Lesson18UserChild(string name) : base(name) { }
        public void SayHello()
        {
            Console.WriteLine($"hello {name}");
        }
        public override void SayHi()
        { // override
            Console.WriteLine($"[admin] hi {name}");
        }
    }
    */

    /*
    class Lesson19User
    {
        public    string public_str     = "public";
        protected string protected_str  = "protectred";
        private   string private_str    = "private";
        public void Showattrs()
        {
            Console.WriteLine("Lesson19User:" + public_str);
            Console.WriteLine("Lesson19User:" + protected_str);
            Console.WriteLine("Lesson19User:" + private_str);
        }
    }

    class Lesson19UserChild: Lesson19User
    {
        public void ShowattrsC()
        {
            Console.WriteLine("Lesson19User:" + public_str);
            Console.WriteLine("Lesson19User:" + protected_str);
            // Console.WriteLine("Lesson19User:" + private_str); // privateは継承できないのでコンパイルエラー
        }
    }
    */

    /*
    class Lesson20User
    {
        private string name = "hoge";

        //プロパティ
        public string Name
        {
            get { return this.name;  }
            set {
                if (value != "")
                {
                    this.name = value;
                }
            }
        }
        //public string Name { get; set; } = "hoge"; // 短縮形
    }
    */

    /*
    class Lesson21Bean
    {
        private string[] members = new string[3];
        public string this[int i]
        {
            get { return this.members[i]; }
            set { this.members[i] = value; }
        }
    }
    */

    /*
    class Lesson22User
    {
        private static int count = 0;
        public Lesson22User(){
            Lesson22User.count++;
        }
        public static void ShowCount()
        {
            Console.WriteLine($"# of instances :{count}");
        }
    }
    */

    /*
    abstract class Lesson23User
    {
        public abstract void SayHi();
    }

    class Lesson23Japanese : Lesson23User
    {
        public override void SayHi()
        {
            Console.WriteLine("こんにちは！こんにちは！");
        }
    }

    class Lesson23American : Lesson23User
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi！");
        }
    }
    */

    /*
    interface ILesson24Sharable
    {
        void Share();
    }

    class Lesson24User : ILesson24Sharable
    {
        // インターフェイスで定義されているので、Shareをコメントアウトするとエラーになる
        public void Share()
        {
            Console.WriteLine("share by lesson24user");
        }
    }
    */

    /*
    class Lesson25MyInteger
    {
        public void ShowThreeTime(int x)
        {
            Console.WriteLine(x);
            Console.WriteLine(x);
            Console.WriteLine(x);
        }
    }

    class Lesson25MyData<T>
    {
        // 型を「T」にすることで汎化している
        public void ShowThreeTime(T x)
        {
            Console.WriteLine(x);
            Console.WriteLine(x);
            Console.WriteLine(x);
        }
    }
    */

    /*
    class Lesson29Exception : Exception
    {
        public Lesson29Exception(string msg) : base(msg) { }
    }
    */
}

/*
namespace Lesson26Namespace1
{
    class User
    {
        public void Say()
        {
            Console.WriteLine("hello!");
        }
    }
}


namespace Lesson26Namespace2
{
    class User
    {
        public void Say()
        {
            Console.WriteLine("hi!");
        }
    }
}
*/

/*
struct Point
{
    public int X { get; }
    public int Y { get; }
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
    public void GetInfo()
    {
        Console.WriteLine($"({X} : {Y})");
    }
}
*/

/*
enum Lesson28Direction
{
    Stay,
    Right,
    Left
}

enum Lesson28DirectionByNum
{
    Stay  = 1,
    Right = 2,
    Left  = 3
}
*/