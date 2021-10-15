using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter5.Inheritance.Has_ARelationship
{
    public class Car
    {
        private Radio myRadio = new Radio();

        public void TurnOnRadio(bool onOff)
        {
            //delegate call to inner object
            myRadio.Power(onOff);
        }

        public static void CarRadio()
        {
            Car viper = new Car();
            viper.TurnOnRadio(false);
        }
    }
}
