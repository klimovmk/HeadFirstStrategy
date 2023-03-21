﻿using HeadFirstStrategy.Ducks;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Duck duck = new MallardDuck();
           duck.PerformQueck();
            duck.PerformFly();
        }
    }
}