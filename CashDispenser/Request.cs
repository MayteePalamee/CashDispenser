using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDispenser
{
    /// <summary>
    /// Command to devices
    /// </summary>
    public class Request
    {
        private String status;
        private String reset;
        /// <summary>
        /// get status device.
        /// </summary>
        public String Status
        {
            get { return status; }
            set { status = value; }
        }
        /// <summary>
        /// Reset Device.
        /// </summary>
        public String Reset
        {
            get { return reset; }
            set { reset = value; }
        }
    }
}
