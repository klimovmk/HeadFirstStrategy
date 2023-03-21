using HeadFirstStrategy.Fly;
using HeadFirstStrategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstStrategy.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck() 
        {
            _queckBehavior = new Queck();
            _flyBehavior = new FlyNoWay();
            
        }
        public override void Display()
        {
            Console.WriteLine("MallardDuck Display");
        }
    }
}
