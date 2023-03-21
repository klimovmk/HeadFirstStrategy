using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadFirstStrategy.Fly;
using HeadFirstStrategy.Quack;

namespace HeadFirstStrategy.Ducks
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQueckBehavior _queckBehavior;
        public Duck()
        {

        }

        public abstract void Display();
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void PerformQueck()
        {
            _queckBehavior.Quack();
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void SetFlyBehaivor(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void SetQueckBehavior(IQueckBehavior queckBehavior)
        {
            _queckBehavior = queckBehavior;
        }
    }
}
