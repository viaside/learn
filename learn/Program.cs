//Пространства имен
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;



namespace learn
{
    class Program
    {
        enum ball { green, red, blue, yellow, black};
        static void Main(string[] args)
        {
            //переменные
            int x = 42; //целое число
            double pi = 3.14; //число с плавующей точкей
            char y = 'Z'; //один символ
            bool on = true; //булевой тип
            string Name = "Иван"; //символы
            Console.WriteLine("int - {0};", x);
            Console.WriteLine("double - {0};", pi);
            Console.WriteLine("char - {0};", y);
            Console.WriteLine("bool - {0};", on);
            Console.WriteLine("string - {0};", Name);

            //var переменные
            var num = 15;
            Console.WriteLine(num);

            //константы, они не изменяются
            const double PI2 = 3.14;
            Console.WriteLine(PI2);

            //арифметические операторы
            int q = 10;
            int e = 4;
            int r = q * e;
            Console.WriteLine("Ответ {0}", r);
            Console.WriteLine("10 - 4 = {0}", q - e);

            //присвеивание
            int w = 10;
            w += 5;
            Console.WriteLine("Изменение - {0}", w);

            //инкремет
            int t = 15;
            int u = 20;
            t++;
            u--;
            Console.WriteLine("Добавление по одному {0}, убавляет по одному {1}", t, u);

            //оператор if
            int o = 15;
            int i = 10;
            if (o > i)
            {
                Console.WriteLine("{0} > {1}", o, i);
            }
            else if (o < i)
            {
                Console.WriteLine("{0} < {1}", o, i);
            }
            else if (o == i)
            {
                Console.WriteLine("{0} = {1}", o, i);
            }
            else
            {
                Console.WriteLine("error");
            }

            //оператор switch
            string num3 = "cat";
            switch (num3)
            {
                case "cat":
                    Console.WriteLine("is's cat");
                    break;
                case "dog":
                    Console.WriteLine("it's dog");
                    break;
                case "fish":
                    Console.WriteLine("it's fish");
                    break;
                default:
                    Console.WriteLine("i don't know, who is");
                    break;
            }

            //цикл while
            int g = 1;
            while (g < 6)
            {
                Console.WriteLine("цикл");
                g++;
            }

            //цикл for
            for (int h = 10; h < 15; h += 2)
            {
                Console.WriteLine("цикл for h: {0}", h);
            }

            //цикл do-while, выполняется гарантированно 1 раз
            int a = 5;
            do
            {
                Console.WriteLine("dsf {0}", a);
                a++;
            } while (a < 5);

            //break и continue
            int num5 = 0;
            while (num5 <= 20)
            {
                if (num5 == 15)
                    break;
                Console.WriteLine("все {0}", num5);
                num5 += 5;
            }

            for (int num6 = 0; num6 <= 5; num6++)
            {
                if (num6 == 3)
                    continue;
                Console.WriteLine(num6);
            }

            // && == and, || == or, ! == не
            int z = 10;
            if (z > 5 && z < 15)
            {
                Console.WriteLine("{0} больше пяти и меньше 15", z);
            }

            //условный оператор
            int age = 14;
            string msg;
            msg = (age >= 16) ? "hello" : "bay";
            Console.WriteLine(msg);


            //калькулятор
            /*    int result = 0;
                Console.WriteLine("x:=");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y:=");
                int y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("* или / или + или -?");
                char fun = Convert.ToChar(Console.ReadLine());
                if (fun == '*')
                {
                    result = x1 * y1;
                }
                if (fun == '/')
                {
                    result = x1 / y1;
                }
                if (fun == '+')
                {
                    result = x1 + y1;
                }
                if (fun == '-')
                {
                    result = x1 - y1;
                }
                Console.WriteLine(result);   */

            //вызов метода 
            SayHi(30);

            Console.WriteLine(Test(2, 5));

            int res7 = Test(2, 6);
            Console.WriteLine(res7);

            //вызов перегруженных методов
            Print(3.16);
            Print(213);
            Print("пароль", 123);

            //вызов метода рекурсия
            Console.WriteLine(Fact(4));

            //вызов метода пирамиды
            Pyramid(10);

            //вызов игры
            Console.WriteLine(Points(4));

            //вызов класса
            Person p1 = new Person("vova");
            Console.WriteLine(p1.GetName());

            //посты
            Post post = new Post();
            post.Text = "hello";
            post.PostText();

            //массивы
            int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("myArray = " + myArray[4]);

            //массивы и циклы 
            int[] k = new int[10];
            for (int po = 0; po < 10; po++)
            {
                k[po] = po * 2;
                Console.WriteLine("k = " + k[po]);
            }

            //цикл foreach 
            int[] nums6 = { 25, 25, 65, 75, 95 };
            foreach (int kishki in nums6)
            {
                Console.WriteLine("kishki = " + kishki);
            }
            
            //подсчет суммы
            int[] sumiron = new int[5] { 2, 3, 5, 6, 7 };
            int sum = 0;
            foreach (int x5 in sumiron)
            {
                sum += x5;
            }
            Console.WriteLine("сумма: " + sum);

            //многомерные массивы 
            int[,] many = { { 2, 3 }, { 5, 6 }, { 4, 6 }, { 5, 5 } };
            Console.WriteLine("many = " + many[2, 1]);
            
            //отображение таблицы 
            for (int r5 = 0; r5 < 4; r5++)
            {
                Console.Write(r5 + ": ");
                for (int t5 = 0; t5 < 2; t5++)
                {
                    Console.Write(many[r5, t5] + " ");
                }
                Console.WriteLine();
            }

            //ступенчатый массив 
            int[][] stup = new int[][]
            {
                new int[ ] {1, 5, 6},
                new int[ ] {2, 6, 7},
                new int[ ] {3, 7, 8}
            };
            Console.WriteLine("stup = " + stup[1][1]);

            //свойста массив 
            int[] katya = { 2, 5, 7 };
            Console.WriteLine("кол-во элементов: " + katya.Length);
            Console.WriteLine("кол-во измерений: " + katya.Rank);

            for (int length = 0; length < katya.Length; length++)
            {
                Console.WriteLine("run: " + katya[length]);
            }

            //метода массива 
            int[] arr123 = { 1, 2, 3, 4, 5 };
            Console.WriteLine();
            arr123.Max();
            //работа со строками
            string st = "Some text";
            Console.WriteLine(st);
            Console.WriteLine("длина строки: " + st.Length);
            Console.WriteLine("индекс буквы: " + st.IndexOf('e'));
            Console.WriteLine("вставляет значенин: " + st.Insert(0, "This is "));
            Console.WriteLine("удаляет значение: " + st.Remove(4));
            Console.WriteLine("заменяет значение: " + st.Replace("text", "word"));
            Console.WriteLine("возращает подстроку: " + st.Substring(5));
            Console.WriteLine("провереят есть ли значение: " + st.Contains("text"));

            //Вызов конструктора и деструктора
            Destrucktor d = new Destrucktor();

            //static
            static1 stati1 = new static1();
            Console.WriteLine(static1.count);

            static2.Bark();

            //использование статических классов 
            Console.WriteLine("использование статического класса:" + Math.Pow(2, 3));

            //Math
            //Math.PI; константа пи
            //Math.E; натурально логарифмическое основание
            Math.Max(2, 3);
            Math.Min(2, 2);
            Math.Abs(2); //абсолютное значение
            Math.Sin(2);
            Math.Cos(2);
            Math.Pow(2, 3); //возведение в степень
            Math.Round(2.2); //округление
            Math.Sqrt(2); //квадратный корень

            //Array
            int[] ar = { 1, 2, 3, 4, 5, 6, 7 };
            Array.Reverse(ar);
            Array.Sort(ar);

            //String
            string c1 = " some text ";
            string c2 = " another text ";

            Console.WriteLine(String.Concat(c1, c2));
            Console.WriteLine(String.Equals(c1, c2));

            //DateTime
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.DaysInMonth(2015, 2));


            //this 
            Thistest test5 = new Thistest("zxc");

            //индексаторы

            string str = "hello boy";
            char x4 = str[4];
            Console.WriteLine("index 4: " + x4);

            Indextest c7 = new Indextest();
            c7[0] = "ivan";
            c7[1] = "katya";
            Console.WriteLine(c7[1] + " <3 " + c7[0]);

            Dog dogtest = new Dog();
            Console.WriteLine("legs: " + dogtest.Legs);
            dogtest.Bark();

            Protna pr = new Protna("ivan");
            pr.Speak();

            Shape shp = new Shape();
            shp.Draw();

            Circle cir = new Circle();
            Restangle rest = new Restangle();
            cir.Draw();
            rest.Draw();

            //абстрактные классы
            Abs abs = new Circle2();
            abs.Draw();


            //интерфейссы
            IShape ish = new Circle3();
            ish.Draw();
            ish.Finish();

            //структуры 
            Inventory inv;
            inv.Gun = "m4";
            inv.Bullet = 24;
            inv.list();

            //перерчисления
            ball x9 = ball.red;
            switch(x9)
            {
                case ball.black:
                    Console.WriteLine("black!");
                    break;
                case ball.red:
                    Console.WriteLine("red!");
                    break;
                default:
                    Console.WriteLine("idk");
                    break;
            }

            //исключения
            try
            {
                int[] arr2 = new int[] { 4, 5, 6, 5 };
                Console.WriteLine(arr2[4]);
            }
            catch(Exception )
            {
                Console.WriteLine("error!");
            }

            /*
            int x7, y7;
            try
            {
                x7 = Convert.ToInt32(Console.ReadLine());
                y7 = Convert.ToInt32(Console.ReadLine());
                int result5 = x7 / x7;
                Console.WriteLine(result5);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("нельзя делить на ноль");
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
            finally
            {
                Console.WriteLine("none");
            }
            */

            //обобщенние
            string ab = "hello", ba = "world";
            Swap<string>(ref ab, ref ba);
            Console.WriteLine();

            //обобщение классов 
            Stack<int> intStack = new Stack<int>();
            Stack<string> stringStak = new Stack<string>();
            Stack<Person> personStack = new Stack<Person>();
            intStack.Push(3);
            intStack.Push(6);
            intStack.Push(7);
            Console.WriteLine(intStack.Get(1));

            //list
            List<int> li2 = new List<int>();
            li2.Add(59);
            li2.Add(43);
            li2.RemoveAt(1);
            Console.WriteLine("/nlist: ");
            for (int x11 = 0; x11 < li2.Count; x11++)
            {
                Console.WriteLine(li2[x11]);
            }
                li2.Sort();
            
                Console.WriteLine("/nsort: ");
            for (int x12 = 0; x < li2.Count; x12++)
            {
                Console.WriteLine(li2[x12] + " ");
            }

            //sortedList 
            SortedList<string, int> sl = new SortedList<string, int>();
            sl.Add("Solo", 25);
            sl.Add("Team", 50);
            sl.Add("A", 75);
            sl.Remove("A");
            Console.WriteLine("sorted list:");
            foreach (string s in sl.Keys)
            {
                Console.WriteLine(s + " : " + sl[s]);
            }
            Console.WriteLine("Count: " + sl.Count);

            //bitarray
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);

            ba1.SetAll(true);
            ba2.SetAll(false);

            ba1.Set(3, true);
            ba2.Set(3, false);

            PrintBarr("ba1", ba1);
            PrintBarr("ba2", ba2);
            Console.WriteLine();

            PrintBarr("ba1 AND ba2", ba1.And(ba2));
            PrintBarr("    NOT ba2", ba2.Not());

            //stack
            Stack<int> stack2 = new Stack<int>();
            stack2.Push(59);


            //Dictionary<u,v>
            Dictionary<string, int> d123 = new Dictionary<string, int>();
            d123.Add("dog", 1);
            d123.Add("cat", 2);
            Console.WriteLine("Dictionary: ");
            foreach (string x17 in d123.Keys)
            {
                Console.WriteLine(x17 + "  :  " + d123[x17]);
            }
            Console.WriteLine("Count: {0}", d123.Count);

            //hashset
            HashSet<int> hash = new HashSet<int>();
            hash.Add(59);
            hash.Add(63);
            Console.WriteLine("hashset: ");
            foreach (int x18 in hash)
            {
                Console.WriteLine(x18 + " ");
            }
            Console.WriteLine("count: " + hash.Count);

        }

        //методы
        static void SayHi(int x)
        {
            x /= 2;
            Console.WriteLine(x);
        }

        static int Test(int a, int d)
        {
            return a + d;
        }

        //перегрузка методов
        static void Print(int pass)
        {
            Console.WriteLine("pass = " + pass);
        }

        static void Print(double pass)
        {
            Console.WriteLine("pass = " + pass);
        }

        static void Print(string str, int pass)
        {
            Console.WriteLine(str + " = " + pass);
        }

        //рекурсия
        static int Fact(int factarial)
        {
            if (factarial == 1)
            {
                return 1;
            }
            return factarial * Fact(factarial - 1);
        }

        //пирамида 
        static void Pyramid(int index)
        {
            for (int i1 = 1; i1 <= index; i1++)
            {
                for (int k1 = i1; k1 <= index; k1++)
                {
                    Console.Write("  ");
                }
                for (int h1 = 1; h1 <= 2 * i1 - 1; h1++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }

        //подсчет очков
        static int Points(int levels)
        {
            int point = 0;
            for (int h1 = 1; h1 <= levels; h1++)
            {
                point = point + h1;
            }
            return point;
        }

        //обобщение
        static void Swap<T>(ref T a6, ref T b6)
        {
            T temp = a6;
            a6 = b6;
            b6 = temp;
            Console.WriteLine("temp = {0}, a6 = {1}, b6 = {2}", temp, a6, b6);
        }

        //BitArray
        static void PrintBarr(string name, BitArray ba)
        {
            Console.Write(name + ":");
            for (int x13 = 0; x13 < ba.Length; x13++)
            {
                Console.Write(ba.Get(x13) + " ");
            }
            Console.WriteLine();
        }
    }

    //классы
    class Person
    {
        private string name;
        public Person(string nm)
        {
            name = nm;
        }

        public string GetName()
        {
            return name;
        }

    }

    //пост текстов
    class Post
    {
        private string text;

        public Post()
        {
            Console.WriteLine("New post");
            Console.WriteLine("--------");
        }

        public void PostText()
        {
            Console.WriteLine(text);
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

    }

    //деструкторы
    class Destrucktor
    {
        public Destrucktor()
        {
            Console.WriteLine("create");
        }
        ~Destrucktor()
        {
            Console.WriteLine("clos");
        }

        static void main(string[] args)
        {
            Destrucktor d = new Destrucktor();
        }
    }

    //static
    class static1
    {
        public static int count = 0;
        public static1()
        {
            count++;
        }
    }

    class static2
    {
        public static void Bark()
        {
            Console.WriteLine("wow");
        }
    }

    //this
    class Thistest
    {
        private string name;
        public Thistest(string name)
        {
            this.name = name;
            Console.WriteLine("this: " + this.name);
        }
    }

    //readonly
    class Readonlytest
    {
        private readonly string name = "ivan";
    }

    //index 
    class Indextest
    {
        private string[] name = new string[10];

        public string this[int index]
        {
            get
            {
                return name[index];
            }
            set
            {
                name[index] = value;
            }
        }
    }

    //наследование 
    class Animal
    {
        public int Legs { get; set; }
        public int Body { get; set; }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Legs = 4;
        }
        public void Bark()
        {
            Console.WriteLine("woof");
        }
    }

    //protected
    class Prot
    {
        protected int Age { get; set; }
        protected string Name { get; set; }
    }

    class Protna : Prot
    {
        public Protna(string nm)
        {
            Name = nm;
        }

        public void Speak()
        {
            Console.WriteLine("name: " + Name);
        }
    }

    //sealed
    sealed class seal { }

    //полиморфизм
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("base");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("circle");
        }
    }

    class Restangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("restangle");
        }
    }

    //абстрактные классы 
    abstract class Abs
    {
        public abstract void Draw();
    }

    class Circle2 : Abs
    {
        public override void Draw()
        {
            Console.WriteLine("circle2");
        }
    }

    class Restangle2 : Abs
    {
        public override void Draw()
        {
            Console.WriteLine("restangle2");
        }
    }

    //интерфейсы 
    public interface IShape
    {
        void Draw();
        void Finish()
        {
            Console.WriteLine("Done!");
        }
    }
   
    class Circle3 : IShape
    {
        public void Draw()
        {
            Console.WriteLine("circle3");

        }
    }

    //вложенные классы
    class Car2
    {
        public string Name = "ivan";
        public Car2(string nm)
        {
            Name = nm;
            Car3 m = new Car3();
        }
        public class Car3
        {
            public void Func()
            {
                Console.WriteLine();
            }
        }
    }

    //структуры 
    struct Inventory
    {
        public string Gun;
        public int Bullet;

        public void list()
        {
            Console.WriteLine("your gun: {0}, your Bullet: {1}", Gun, Bullet );
        }
    }

    //обобщенные классы
    class Stack<T>
    {
        int index = 0;
        T[] inner = new T[100];
        public void Push(T item)
        {
            inner[index++] = item;
        }
        public T Pop()
        {
            return inner[--index];
        }
        public T Get(int k)
        {
            return inner[k];
        }
    }

}
