using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Insufficient Fund Exception 
namespace Assignment5
{
    class InsufficientFundException:ApplicationException
    {
        public InsufficientFundException() { }

        public InsufficientFundException(string msg1) :base(msg1) { }
    }
}
