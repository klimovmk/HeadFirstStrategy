using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstStrategy.Fly
{
    internal class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'am flying!");
        }
    }
}
