using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class InvalidAmountException: ApplicationException
    {
        public InvalidAmountException(){ }

        public InvalidAmountException(string msg) : base(msg) { }
    }
}
