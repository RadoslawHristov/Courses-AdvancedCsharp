﻿using System;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(EqualityScale<int>.AreEqual(3, 3));
        }
    }
}
