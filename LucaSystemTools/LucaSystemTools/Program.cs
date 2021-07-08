﻿using System;
using LucaSystem.Utils;
using McMaster.Extensions.CommandLineUtils;

namespace LucaSystemTools
{

    public class Program
    {
        public static bool debug = false;
        public static uint toolVersion = 20201012;
        static void Main(string[] args)
        {
            Test.TestMain();
            if (args.Length > 0)
            {
                CommandLineApplication.Execute<CommandLineUtil>(args);
                Console.WriteLine("ok!");
            }
            else
            {
                Console.WriteLine("please input params");
                Console.ReadLine();
            }
        }
    }
}
