﻿using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            APITest t = new APITest();
            t.GetData().Wait();
        }
    }
}
