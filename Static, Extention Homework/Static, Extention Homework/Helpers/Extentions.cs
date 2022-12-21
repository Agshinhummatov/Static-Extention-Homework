using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Static__Extention_Homework.Helpers
{
    internal static class Extentions
    {
        public static int GetNum(this int num)
        {
            return  num;
        }


         public static bool CheckDigitInString(this string text)
         {

            return Regex.IsMatch(text, @"\d");

         }
         
         public static bool ChechString(this string text,string pattren)
        {
            return Regex.IsMatch(text, pattren);

          }

        //Tasks: 1) int ucun faktoriali hesablayan extention yazin


        public static int Faktorial(this int num)
        {

            int res = 1;
            while (num != 1)
            {
                res = res * num;
                num = num - 1;
            }

            return res;
        }

        //public static int Power(this int num, int pow)
        //{


        //    Console.WriteLine("Ededi daxil edin");

        //    int num = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Quvvet daxil edin");

        //    int pow = int.Parse(Console.ReadLine());


        //    double result = Math.Pow(num, pow);

        //    Console.WriteLine($"Netice:{result}");


        //}




    }
}
