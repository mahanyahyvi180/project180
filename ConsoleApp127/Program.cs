﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp127
{
    class SCOPE
    {
        private static int x = 1;
    
        static void Main(string[] args)
        {
            int x = 5;

            Console.WriteLine($"local x in method Main is{x}");

            UseLocalVariable();

            UseStaticVariable();

            UseLocalVariable();

            UseStaticVariable();

            Console.WriteLine($"\nlocal x in method Main is{x}");

        }


        static void UseLocalVariable()
        {
            int x = 25;

            Console.WriteLine($"\nlocal x on entering method UseLocalVariable is{x}");

            ++x;

            Console.WriteLine($"local x before exiting method UseLocalVariable is{x}");
        }

        static void UseStaticVariable()
        {
            Console.WriteLine("\nstatic variable x on entering method" + $"UseStaticVariable is{x}");

            x *= 10;

            Console.WriteLine("static variable x before exiting " + $"method UseStaticVariable is{x}");
            Console.ReadLine();
        }
    }
}
