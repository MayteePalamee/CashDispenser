using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace CashDispenser
{
    public class Cashdispenser : SerialPortHelper, IDevicesHelper
    {
       public Cashdispenser()
       {
            /**
             * Read file application.config & set POJO Response class 
             **/
            var config = new System.Configuration.AppSettingsReader();
            new Response
            {
                SinglePayout = config.GetValue("singlePayout", typeof(string)).ToString(),
                MultiplePayout = config.GetValue("multiplePayout", typeof(string)).ToString(),
                PayoutSuccessful = config.GetValue("payoutSuccessful", typeof(string)).ToString(),
                PayoutFails = config.GetValue("payoutFails",typeof(string)).ToString(),
                Ready = config.GetValue("ready",typeof(string)).ToString(),
                EmptyNote = config.GetValue("emptyNote",typeof(string)).ToString(),
                StockLess = config.GetValue("stockLess",typeof(string)).ToString(),
                NoteJam = config.GetValue("noteJam",typeof(string)).ToString(),
                OverLength = config.GetValue("overLength",typeof(string)).ToString(),
                NoteNotExit = config.GetValue("noteNotExit",typeof(string)).ToString(),
                SensorError = config.GetValue("sensorError",typeof(string)).ToString(),
                DoubleNoteError = config.GetValue("doubleNoteError",typeof(string)).ToString(),
                MotorError = config.GetValue("motorError",typeof(string)).ToString(),
                DispeningBusy = config.GetValue("dispeningBusy",typeof(string)).ToString(),
                SensorAdjusting = config.GetValue("sensorAdjusting",typeof(string)).ToString(),
                ChecksumError = config.GetValue("checksumError",typeof(string)).ToString(),
                LowpowerError = config.GetValue("lowpowerError",typeof(string)).ToString()
            };
       }
       /**
       * event delegate.
       * Declare the event using EventHandler<T>
       **/
        public event EventHandler<Events> RaiseEvents;

        /**
         * delegate method handle raise event
         **/
        protected virtual void OnRaiseEvent(Events e)
        {
            RaiseEvents?.Invoke(this, e);
        }
        /**Initialzed**/
        private SerialPort _serialPort = new SerialPort();
        Response status;

        public Accept Connect()
        {
            try
            {
                System.Console.Write("test : "+status.SinglePayout);
            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return null;
        }

        public Response Disabled()
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }

        public Response Disconnect()
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }

        public Response Enabled()
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }

        public Response Parallel(string command)
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }

        public Response Received()
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }

        public Response Transmitte(string command)
        {
            status = new Response();
            try
            {

            }
            catch (Exception ex)
            {
                status.Fault = ex.Message;
                OnRaiseEvent(new Events(status.Fault));
            }
            return status;
        }

        public Accept Accept(string code, string discription)
        {
            Accept accept = new Accept
            {
                Code = code,
                Discription = discription
            };

            return accept;
        }
    }
}
