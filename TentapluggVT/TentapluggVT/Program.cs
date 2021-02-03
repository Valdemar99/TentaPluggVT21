using System;

namespace TentapluggVT
{
    class Program
    {
        public delegate void MyDelegate(int i);

        public static void Call(MyDelegate myDelegate1, MyDelegate myDelegate2)
        {
            myDelegate1(1);
            myDelegate2(30);
        }
        static void F1(int i) { Console.WriteLine("callback metodf1 " + i); }
        static void F2(int i) { Console.WriteLine("callback metodf2 " + i); }

        static void Main(string[] args)
        {
            MyDelegate m1 = new MyDelegate(F1);
            m1(30);
            F1(30);
            Console.ReadLine();
            //MyDelegate m2
        }
    }
}
