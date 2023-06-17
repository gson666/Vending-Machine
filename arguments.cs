using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virualproject
{
    internal class arguments : Exception
    {
        public int maxdrinks { get;private set; }
        public arguments() { }
        public arguments(string message) : base (message) { }
        public arguments(string message , Exception inner) : base(message, inner) { }
        public arguments(int num) { maxdrinks = num; }
        public arguments (string message, int num) : base(message) { maxdrinks = num; }



    }
}
