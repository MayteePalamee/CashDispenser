using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDispenser
{
    /// <summary>
    /// 
    /// </summary>
    public class State
    {
        private String code;
        private String message;
        /// <summary>
        /// 
        /// </summary>
        public String Code
        {
            get { return code; }
            set { code = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String Discription
        {
            get { return message; }
            set { message = value; }
        }
    }
}
