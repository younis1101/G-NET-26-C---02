using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FileName
    {

        static void main(string[] args)
        {
            #region Question 1 : 
            ///A junior developer wrote this code to build acomma-separated list of 5,000 product IDs:
            /// a) Explain why this code is inefficient.Reference what happens in memory.



            // Inefficient code (assuming this is what the junior wrote)
            //string result = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    result += i + ",";

            /// (b)Rewrite this code using StringBuilder to be more efficient.
            //StringBuilder sb = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append(i);
            //    sb.Append(",");
            //}

            //string result = sb.ToString().TrimEnd(',');
            //Console.WriteLine(result);
            ///(c)Add timing code(using Stopwatch) to both versions and report
            ///the time difference.



            // Normal String Concatenation
            //Stopwatch sw1 = new Stopwatch();
            //sw1.Start();

            //string result1 = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    result1 += i;
            //    if (i < 5000)
            //        result1 += ",";
            //}

            //sw1.Stop();
            //Console.WriteLine("String Time: " + sw1.ElapsedMilliseconds + " ms");


            //// StringBuilder
            //Stopwatch sw2 = new Stopwatch();
            //sw2.Start();

            //StringBuilder sb = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append(i);
            //    if (i < 5000)
            //        sb.Append(",");
            //}

            //string result2 = sb.ToString();

            //sw2.Stop();
            //Console.WriteLine("StringBuilder Time: " + sw2.ElapsedMilliseconds + " ms");




            #endregion







        }
    }


}



    
        







    






