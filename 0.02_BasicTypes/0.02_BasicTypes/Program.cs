﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value types, stored on the Stack

            int i = 0;  // implicit conversion, too, a.k.a Int32
            short sh = 32767; // 2^16, or 32768, or */- 0-32767. a.k.a Int16
            byte by = 255; //2^8, or 256, or +/- 0-255, a.k.a. Byte
            string s = "hey!"; // up to gigs in size, or 2*32 bytes, or Int32.MaxValue, a.k.a. String
            char c = 'i'; // a string is just a linked list of chars, note the single quotes, a.k.a. Char
            var s2 = @"a \tree";
            var s3 = "a \tree";
            bool b = false; // 1 = true, 0 = false, a.k.a. Boolean
            long l = 7; // long int, 64-bit, a.k.a. Int64
            decimal p; // 128-bit precision decimal, very expensive, a.k.a. Decimal
            double d = 7.80; //64-bit decimal, a.k.a. Double
            float f = 10.8f; // floating point intiger, must put f *explicit* conversion afterwards
                             //if using a constant, or you could cast as (float)
            decimal dd = 7.80m; //must add the m if using a constant, or you could cast as (decimal)
            int? ni = null; // nullable variables, use .HasValue to determine if they are populated,
            //useful with wed services, database results

            //DECLARATION ONLY
            int number;
            string name;
            bool IsValid;
            
            //DECLARATION & INITIALIZATION
            int year = 2017;
            string country = "United States of America";

            //Using Console.WriteLine
            Console.WriteLine(s2);
            Console.WriteLine("i = {0}, sh = {1}", i, sh);
            Console.WriteLine(i + sh);

            //Bronze Challenge
            Console.WriteLine("int, string, bool, float, double, decimal");
            int  x;
            int o = 70;
            string sample;
            string example = "example";
            bool sbool;
            bool t = true;
            float Float;
            float ii = 12.32f;
            double ll;
            double ff = 6.90;
            decimal q;
            decimal dt = 0.97m;
            Console.WriteLine(o);
            Console.WriteLine(example);
            Console.WriteLine(t);
            Console.WriteLine(ii);
            Console.WriteLine(ff);
            Console.WriteLine(dt);
            Console.WriteLine("Value of types: " + o + " and " + example + " and " + t + " and " + ii + " and " + ff + " and finally " + dt);
            //string yearBorn = "1991";
            int yearBorn = Int32.Parse("1991");
            Console.WriteLine("I was born in in: " + yearBorn);



            //Ude this to get console to pop up.
            Console.ReadLine();
        }
    }
}
