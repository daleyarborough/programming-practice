using programming_practice.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_practice
{
    public class CheckValue : ICheckValue
    {
        public CheckValue()
        {

        }

        public string name = string.Empty;

        public string Name 
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public void ReturnIfContainsMyName(string name)
        {
            if (name == "dale")
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}