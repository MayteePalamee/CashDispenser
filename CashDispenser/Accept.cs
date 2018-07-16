using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDispenser
{
    public class Accept
    {
        private String code;
        private String message;

        public String Code
        {
            get { return code; }
            set { code = value; }
        }
        public String Discription
        {
            get { return message; }
            set { message = value; }
        }
    }
}
