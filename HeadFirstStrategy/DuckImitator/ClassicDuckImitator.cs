using HeadFirstStrategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstStrategy.DuckImitator
{
    public class ClassicDuckImitator : DuckImitator
    {
        public ClassicDuckImitator()
        {
            _queackBehavior = new Queck();
        }
    }
}
