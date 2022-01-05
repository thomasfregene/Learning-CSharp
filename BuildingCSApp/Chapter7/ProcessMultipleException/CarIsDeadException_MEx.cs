using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter7.ProcessMultipleException
{
    public class CarIsDeadException_MEx : ApplicationException
    {
        private string MessageDetails = string.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
        public CarIsDeadException_MEx() { }
        public CarIsDeadException_MEx(string message, string cause, DateTime time)
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
}
