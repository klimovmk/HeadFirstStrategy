using HeadFirstStrategy.Fly;
using HeadFirstStrategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstStrategy.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _queckBehavior = new Queck();
        }

        public override void Display()
        {
            Console.WriteLine("I'am Model Duck");
        }
    }
}
