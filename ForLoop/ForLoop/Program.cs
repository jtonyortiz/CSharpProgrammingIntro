﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "For-Loop";

            for(int i = 1; i < 4; i++)
            {
                Console.WriteLine("Loop Iteration:" + i);
                for(int j = 1; j < 4; j++)
                {
                    Console.WriteLine("\tInner-Loop Iteration: " + j);
                }
            }//outer-for-loop

            Console.ReadKey();

        }
    }
}
