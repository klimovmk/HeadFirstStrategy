using HeadFirstStrategy.DuckImitator;
using HeadFirstStrategy.Ducks;
using HeadFirstStrategy.Fly;
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

            Duck modelDuck = new ModelDuck();

            modelDuck.PerformFly();

            modelDuck.SetFlyBehaivor(new FlyRocketPowered());

            modelDuck.PerformFly();

            Console.WriteLine("____________________________");

            Console.WriteLine();

            DuckImitator duckImitator = new ClassicDuckImitator();
            duckImitator.PerformQueack();


            
        }
    }
}