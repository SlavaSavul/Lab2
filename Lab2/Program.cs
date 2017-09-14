using System;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.SByte sb = SByte.MaxValue;
            System.Byte b = Byte.MaxValue;
            System.Int16 i16 = Int16.MaxValue;
            System.Int32 i32 = Int32.MaxValue;
            System.Int64 i64 = Int64.MaxValue;
            System.UInt16 ui16 = UInt16.MaxValue;
            System.UInt32 ui32 = UInt32.MaxValue;
            System.UInt64 ui64 = UInt64.MaxValue;
            System.Char ch = 'C';
            System.Boolean bol = true;
            System.Single fl = Single.MaxValue;
            System.Double db = Double.MaxValue;
            System.Decimal dc = Decimal.MaxValue;
            System.String st = "Hello, world!";
            System.Object obj = null;

            /*
            Console.WriteLine(
               $"sb={sb}\n" +
               $"b={b}\n" +
               $"i16={i16}\n" +
               $"i32={i32}\n" +
               $"i64={i64}\n" +
               $"ui16={ui16}\n" +
               $"ui32={ui32}\n" +
               $"ui64={ui64}\n" +
               $"ch={ch}\n" +
               $"bol={bol}\n" +
               $"fl={fl}\n" +
               $"db={db}\n" +
               $"dc={dc}\n" +
               $"st={st}\n" +
               $"obj={obj}\n");*/

            byte b1 = 1;
            short b2 = b1;
            int b3 = b2;
            long b4 = b3;
            double b5 = b4;
            //Console.WriteLine(b5);

            double d1 = 1.543;
            long d2 = (long)d1;
            Console.WriteLine("d2={0}", d2);
            int i1 = Int32.MaxValue;
            short i2 = (short)i1;
            Console.WriteLine("i2={0}", i2);
            short s1 = 5545;
            byte s2 = (byte)s1;
            Console.WriteLine("s2={0}", s2);
            int I1 = -123;
            uint I2 = (uint)I1;
            Console.WriteLine("I2={0}", I2);

            double D1 = 4.123031777776333;
            float D2 = (float)D1;
            Console.WriteLine("D2={0}", D2);


            int X;
            object Obj;
            X = 10;
            Obj = X;
            int Y = (int)Obj;
            Console.WriteLine("Y={0}", Y);




            var Str = "Hello, world!";
            Console.WriteLine(Str.GetType());



            int? null1 = null;
            int null2 = null1 ?? 5;
            Console.WriteLine("null2={0}", null2);

            char[] a = { 'f', 'f', 'f', 'f' };
            string a1 = new string(a);
            string a2 = new string('f', 4);
            Console.WriteLine(a1 == a2);

            /*Console.WriteLine(String.Compare("a","a"));
            Console.WriteLine(String.Compare("a", "b"));
            Console.WriteLine(String.Compare("b", "a"));*/

            string Str1 = "Hello";
            string Str2 = ", ";
            string Str3 = "world!";
            Console.WriteLine(String.Concat(Str1, Str2, Str3));

            Console.WriteLine();


            string text = "Thisstring";

            text = text.Insert(4, " is");
            text = text.Insert(7, " a ");
            text = text.Insert(10, "My ");

            text = text.Remove(10, 3);

            string[] words = text.Split(' ');
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }



            string NullSt = "";









            Console.ReadKey();
        }
    }
}
