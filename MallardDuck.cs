using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_practice
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Console.WriteLine("I am a real Mallard Duck...");
            quackBehavior = new Quack();
            flyingBehavior = new FlyWithWings();
        }
    }
}
