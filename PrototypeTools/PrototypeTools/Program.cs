﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProtScript;

namespace PrototypeTools
{
    class Program
    {
        static string work = @"E:\汉化项目\switch\SummerPocket\";
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(work + @"UnpackFile\SCRIPT.PAK~", "*");

            //foreach (var file in files)
            //{
            //    if (Path.GetExtension(file) == ".txt") continue;
            //    if (Path.GetFileName(file) == "_CGMODE") continue;
            //    if (Path.GetFileName(file) == "_VOICE_PARAM") continue;
            //    Console.WriteLine(file);
            //    ScriptParser scr = new ScriptParser(file);
            //    scr.Decompress();
            //    scr.Close();
            //}
            ScriptParser scr = new ScriptParser(work + @"Temp\10_プロローグ0725", true);
            scr.Decompress();
            scr.Close();
            Console.ReadKey();

        }
    }
}
