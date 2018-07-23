using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace CashDispenser
{
    /// <summary>
    /// Cash Dispenser
    /// </summary>
    public class Cashdispenser : SerialPortHelper
    {
       /// <summary>
       /// Initial Command
       /// </summary>
       public Cashdispenser()
       {
            new Response
            {
                SinglePayout = "01100010",
                MultiplePayout = "01100113",
                PayoutSuccessful = "010100AA",
                PayoutFails = "010100BB",
                Ready = "01010000",
                EmptyNote = "01010001",
                StockLess = "01010002",
                NoteJam = "01010003",
                OverLength = "01010004",
                NoteNotExit = "01010005",
                SensorError = "01010006",
                DoubleNoteError = "01010007",
                MotorError = "01010008",
                DispeningBusy = "01010009",
                SensorAdjusting = "0101000A",
                ChecksumError = "0101000B",
                LowpowerError = "0101000C",
            };

            new Request
            {
                Status = "011000110022",
                Reset = "011000120023"
            };
        }
        /// <summary>
        /// Declare the event using EventHandler Message
        /// </summary>
        public event EventHandler<Events> MessageEvents;
        /// <summary>
        /// Declare the event using EventHandler Cash Dispenser
        /// </summary>
        public event EventHandler<Events> Dispenser;
        /// <summary>
        /// delegate method handle Message
        /// </summary>
        /// <param name="e">message</param>
        protected virtual void OnMessage(Events e)
        {
            MessageEvents?.Invoke(this, e);
        }
        /// <summary>
        /// delegate method handle Dispenser
        /// </summary>
        /// <param name="e">message</param>
        protected virtual void OnDispenser(Events e)
        {
            Dispenser?.Invoke(this, e);
        }

        /**Initialzed**/
        private SerialPort _serialPort = new SerialPort();
        State status;
        /// <summary>
        /// Connect to Device
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Connect()
        {
            bool result = false; 
            try
            {
                _serialPort = Initial();
                _serialPort.DataReceived += _serialPortDataReceived;

                System.Console.Write("test");
            }
            catch (Exception e)
            {
                OnMessage(new Events(e.Message));
            }
            return result;
        }

        private void _serialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            OnDispenser(new Events("Dispenser"));
        }

        /// <summary>
        /// get status from device
        /// </summary>
        /// <returns>data object</returns>
        public State State()
        {
            status = new State();
            try
            {

            }
            catch (Exception e)
            {
                OnMessage(new Events(e.Message));
            }
            return status;
        }
        /// <summary>
        /// send command reset device
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Reset()
        {
            bool result = false;
            try
            {

            }
            catch (Exception e)
            {
                OnMessage(new Events(e.Message));
            }
            return result;
        }
        /// <summary>
        /// send command disabled device
        /// </summary>
        /// <returns>boolean</returns>
        public Boolean Disabled()
        {
            bool result = false;
            try
            {

            }
            catch (Exception e)
            {
                OnMessage(new Events(e.Message));
            }
            return result;
        }
        /// <summary>
        /// disconnect device
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Disconnect()
        {
            bool result = false;
            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                    result = true;
                }
            }
            catch (Exception e)
            {
                OnMessage(new Events(e.Message));
            }
            return result;
        }
        /// <summary>
        /// send command Enable Device
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean Enabled()
        {
            bool result = false;
            try
            {

            }
            catch (Exception e)
            {
                OnMessage(new Events(e.Message));
            }
            return result;
        }
        /// <summary>
        /// send command to device
        /// </summary>
        /// <param name="command">command for send to device</param>
        /// <returns>Boolean</returns>
        public Boolean Transmitte(string command)
        {
            bool result = false;
            try
            {

            }
            catch (Exception e)
            {
                OnMessage(new Events(e.Message));
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="discription"></param>
        /// <returns></returns>
        private State SetState(string code, string discription)
        {
            State accept = new State
            {
                Code = code,
                Discription = discription
            };

            return accept;
        }
    }
}
