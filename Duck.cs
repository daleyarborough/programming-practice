using programming_practice.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_practice
{
    public class Duck
    {
        public IQuackBehavior quackBehavior;

        public IFlyingBehavior flyingBehavior;

        public void performQuack()
        {
            quackBehavior.Quack();
        }

        public void performFly()
        {
            flyingBehavior.Fly();
        }
    }
}
