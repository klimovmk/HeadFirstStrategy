using HeadFirstStrategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstStrategy.DuckImitator
{
    public class DuckImitator
    {

        protected IQueckBehavior _queackBehavior;
        public DuckImitator() { }

        public void PerformQueack()
        {
            _queackBehavior.Quack();
        }
    }
}
