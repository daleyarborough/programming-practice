using programming_practice.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_practice
{
    public class FlyWithWings : IFlyingBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying like a duck!!!");
        }
    }
}
