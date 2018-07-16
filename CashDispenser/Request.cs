using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDispenser
{
    public class Request
    {
        private String status;
        private String reset;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }
        public String Reset
        {
            get { return reset; }
            set { reset = value; }
        }
    }
}
