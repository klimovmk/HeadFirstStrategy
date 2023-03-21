using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstStrategy.Quack
{
    internal class SQueck : IQueckBehavior
    {
        public void Quack()
        {
            Console.WriteLine("SQuack");
        }
    }
}
