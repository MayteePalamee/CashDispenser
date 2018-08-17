using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDispenser
{
    /// <summary>
    /// cash dispenser device
    /// </summary>
    public enum Status
    {
    
        Ready,
        Disconnected,
        Single_machine_payout,
        Multiple_machine_payout,
        Payout_successful,
        Payout_fails,
        Empty_note,
        Stock_less,
        Note_jam,
        Over_length,
        Note_Not_Exit,
        Sensor_Error,
        Double_note_error,
        Motor_Error,
        Dispensing_busy,
        Sensor_adjusting,
        Checksum_Error,
        Low_power_Error
    }
}
