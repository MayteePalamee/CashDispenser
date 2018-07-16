using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDispenser
{
    public interface IDevicesHelper
    {
        Accept Connect();
        Response Transmitte(String command);
        Response Disconnect();
        Response Enabled();
        Response Disabled();
        Response Received();
        Response Parallel(String command);
        Accept Accept(String code, String discription);
    }
}
