using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Question 1
            /// What will this print and explain what happens?

            //double d = 9.99;
            //int x = (int)d;
            //Console.WriteLine(x);
            #endregion

            #region Question 2
            ///This code doesn’t compile. Fix it with the smallest change?

            //int n = 5;
            //double d2 = n / 2.0;
            //Console.WriteLine(d2); // 2.5
            #endregion

            #region Question 3
            ///You read a number from user input ..Write the correct line to get age as int.

            // int age = int.Parse(Console.ReadLine());

            #endregion

            #region Question 4
            ///What happens here and why ?
            // string s = "12a";
            //int x = int.Parse(s);
            //Console.WriteLine(x);
            #endregion
            #region Question 5
            //Complete the code from the previous question so it prints
            //Invalid if conversion into int fails, otherwise prints the number
            //1

            //string s = "12a";
            //if (int.TryParse(s, out int x))
            //    Console.WriteLine(x);
            //else
            //    Console.WriteLine("Invalid");
            #endregion

            #region Question 6
            ///What will this print and explain why ?
            //object o = 10;
            //int a = (int)o;
            //Console.WriteLine(a + 1);
            #endregion


            #region Question 7
            /// What will this print and explain why and if there is a problem handle it ?

            //object o = 10;
            //long x = (long)o;
            //Console.WriteLine(x);
            #endregion
        }
    }
}
