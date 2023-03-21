using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstStrategy.Quack
{
    internal class QueckMute : IQueckBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }

    }
}
