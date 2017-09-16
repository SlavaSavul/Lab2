using System;
using System.Text;

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


            int ? null1 = null;
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

            Console.WriteLine("--------------------------------------------");

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


            Console.WriteLine("--------------------------------------------");

            string NullSt = "";

            if (String.Compare(NullSt, Str1) != 0)
            {
                Console.WriteLine("String is not empty");
            }
            else
            {
                Console.WriteLine("String is empty");
            }

            Console.WriteLine("--------------------------------------------");


            StringBuilder StrB = new StringBuilder("world");
            StrB.Append("!!!!!");

            StrB.Insert(0, "Beautiful ");
            Console.WriteLine(StrB);


            Console.WriteLine("--------------------------------------------");



            int[][] Mas = new int[3][];

            Mas[0] = new int[5] { 1, 2, 3, 4, 5 };
            Mas[1] = new int[4] { 1, 2, 3, 4 };
            Mas[2] = new int[4] { 1, 2, 3, 4 };

            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = 0; j < Mas[i].Length; j++)
                {
                    Console.Write($"  { Mas[i][j]}   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            Console.WriteLine("--------------------------------------------");


            string[] MasStr = { "aaaaaaaaa", "11111111", "44444444444" };


            Console.WriteLine($"Size MasStr={MasStr.Length}");
             Console.WriteLine("Enter number and value\n");
             int num=Int32.Parse(Console.ReadLine());


             MasStr[num] = Console.ReadLine();




            Console.WriteLine("--------------------------------------------");

            Console.WriteLine();


             for (int i=0;i< MasStr.Length;i++ )
             {
                 Console.WriteLine(MasStr[i]);

             }
             Console.WriteLine();



            Console.WriteLine("--------------------------------------------");




            double[][] MasD = new double[3][];

            for(int i=0;i< MasD.Length;i++)
            {
                MasD[i] = new double[i + 1];
                for (int j=0;j<i+1;j++)
                {
                    MasD[i][j] = Double.Parse(Console.ReadLine());
                }
            }
            

            
            for (int i = 0; i < MasD.Length; i++)
            {
                for (int j = 0; j < MasD[i].Length; j++)
                {
                    Console.Write($"  { MasD[i][j]}   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("--------------------------------------------");


            var MasInt = new[] { 12.23, 323.2, 322 };
            var MasString = new[] { "ABC", null };



            ValueTuple<int, string, char, string, ulong> cortage = (num1: 1, num2: "22", num3: 'f', num4: "rrr", num5: UInt64.MaxValue);


            Console.WriteLine($"{cortage.Item1} {cortage.Item3} { cortage.Item4}");

                int CorInt = cortage.Item1;
            string CorStr1 = cortage.Item2;
            string CorStr2 = cortage.Item4;
            char CorCh = cortage.Item3;
            ulong CorUl = cortage.Item5;




            int[] arr = new int[4] {1,2,3,4 };

            var Typle=MyFunction(arr,text);

            Console.WriteLine(Typle);
            Console.WriteLine("--------------------------------------------");






            Console.ReadKey();
        }
        static ValueTuple<int, int, int, char> MyFunction(int[] arr,string str)
        {
            int Max = arr[0];
            int Min = arr[0];
            int Sum = 0;
            for (int i=0;i<arr.Length;i++)
            {
                if (Max < arr[i]) Max = arr[i];
                if (Min > arr[i]) Max = arr[i];
                Sum += arr[i];
            }
            ValueTuple<int, int,int, char> cortage = (Max,Min,Sum,str[0]);
            return cortage;
        }


    }

}
