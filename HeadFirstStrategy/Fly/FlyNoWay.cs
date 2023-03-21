using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstStrategy.Fly
{
    internal class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'am cant fly");
        }
    }
}
