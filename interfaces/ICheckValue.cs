using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_practice.interfaces
{
    public interface ICheckValue
    {
        public string Name { get; set; }
        public void ReturnIfContainsMyName(string name);
    }
}
