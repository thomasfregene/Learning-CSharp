using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter7.CustomException
{
    public class CarIsDeadException : ApplicationException
    {
        private string MessageDetails = string.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
        public CarIsDeadException() { }
        public CarIsDeadException(string message, string cause, DateTime time)
        {
            MessageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        //overrie the Exception.Message property
        public override string Message 
        {
            get
            {
                return string.Format("Car Error Message: {0}", MessageDetails);
            }
        }

    }


    [Serializable]
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
