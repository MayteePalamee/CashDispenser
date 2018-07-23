using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDispenser
{
    /// <summary>
    /// data response
    /// </summary>
    public class Response
    {
        private String singlePayout;
        private String multiplePayout;
        private String payoutSuccessful;
        private String payoutFails;
        private String emptyNote;
        private String stockLess;
        private String noteJam;
        private String overLength;
        private String noteNotExit;
        private String sensorError;
        private String doubleNoteError;
        private String motorError;
        private String dispeningBusy;
        private String sensorAdjusting;
        private String checksumError;
        private String lowpowerError;
        private String ready;
        /// <summary>
        /// 
        /// </summary>
        public String Ready
        {
            get { return ready; }
            set { ready = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String SinglePayout
        {
            get { return singlePayout; }
            set { singlePayout = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String MultiplePayout
        {
            get { return multiplePayout; }
            set { multiplePayout = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String PayoutSuccessful
        {
            get { return payoutSuccessful; }
            set { payoutSuccessful = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String PayoutFails
        {
            get { return payoutFails; }
            set { payoutFails = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String EmptyNote
        {
            get { return emptyNote; }
            set { emptyNote = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String StockLess
        {
            get { return stockLess; }
            set { stockLess = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String NoteJam
        {
            get { return noteJam; }
            set { noteJam = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String OverLength
        {
            get { return overLength; }
            set { overLength = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String NoteNotExit
        {
            get { return noteNotExit; }
            set { noteNotExit = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String SensorError
        {
            get { return sensorError; }
            set { sensorError = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String DoubleNoteError
        {
            get { return doubleNoteError; }
            set { doubleNoteError = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String MotorError
        {
            get { return motorError; }
            set { motorError = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String DispeningBusy
        {
            get { return dispeningBusy; }
            set { dispeningBusy = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String SensorAdjusting
        {
            get { return sensorAdjusting; }
            set { sensorAdjusting = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String ChecksumError
        {
            get { return checksumError; }
            set { checksumError = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public String LowpowerError
        {
            get { return lowpowerError; }
            set { lowpowerError = value; }
        }
    }
}
