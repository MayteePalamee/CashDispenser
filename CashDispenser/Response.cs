using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDispenser
{
    public class Response
    {
        private String connect;
        private String disconnect;
        private String fault;
        private String unavailable;
        private String singlePayout;
        private String multiplePayout;
        private String payoutSuccessful;
        private String payoutFails;
        private String ready;
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

        public String Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        public String Disconnect
        {
            get { return disconnect; }
            set { disconnect = value; }
        }
        public String Unavailable
        {
            get { return unavailable; }
            set { unavailable = value; }
        }
        public String Fault
        {
            get { return fault; }
            set { fault = value; }
        }
        public String SinglePayout
        {
            get { return singlePayout; }
            set { singlePayout = value; }
        }
        public String MultiplePayout
        {
            get { return multiplePayout; }
            set { multiplePayout = value; }
        }
        public String PayoutSuccessful
        {
            get { return payoutSuccessful; }
            set { payoutSuccessful = value; }
        }
        public String PayoutFails
        {
            get { return payoutFails; }
            set { payoutFails = value; }
        }
        public String Ready
        {
            get { return ready; }
            set { ready = value; }
        }
        public String EmptyNote
        {
            get { return emptyNote; }
            set { emptyNote = value; }
        }
        public String StockLess
        {
            get { return stockLess; }
            set { stockLess = value; }
        }
        public String NoteJam
        {
            get { return noteJam; }
            set { noteJam = value; }
        }
        public String OverLength
        {
            get { return overLength; }
            set { overLength = value; }
        }
        public String NoteNotExit
        {
            get { return noteNotExit; }
            set { noteNotExit = value; }
        }
        public String SensorError
        {
            get { return sensorError; }
            set { sensorError = value; }
        }
        public String DoubleNoteError
        {
            get { return doubleNoteError; }
            set { doubleNoteError = value; }
        }
        public String MotorError
        {
            get { return motorError; }
            set { motorError = value; }
        }
        public String DispeningBusy
        {
            get { return dispeningBusy; }
            set { dispeningBusy = value; }
        }
        public String SensorAdjusting
        {
            get { return sensorAdjusting; }
            set { sensorAdjusting = value; }
        }
        public String ChecksumError
        {
            get { return checksumError; }
            set { checksumError = value; }
        }
        public String LowpowerError
        {
            get { return lowpowerError; }
            set { lowpowerError = value; }
        }
    }
}
