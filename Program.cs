﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            String ipt;
            Console.WriteLine("hello CSharp world!!");
            Console.WriteLine("첫 번째 정수 입력 : ");
            abc:
            /*
            ipt = Console.ReadLine();
            num1 = int.Parse(ipt);
            */
            
            num1 = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수 입력 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
            Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
            Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
            Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
            goto abc;



        }
    }
}
