﻿using System;
using System.Linq;
using System.Collections.Generic;
namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            //LINQ Query using Method Syntax
            var MethodSyntax = integerList.Where(obj => obj > 5).ToList();
            //Execution
            foreach (var item in MethodSyntax)
            {
                Console.Write(item + " ");
            }
        }
    }
}
