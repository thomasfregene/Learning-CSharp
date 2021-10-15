using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter5.Inheritance.Has_ARelationship
{
    public class Radio
    {
        public void Power(bool turnOn)
        {
            Console.WriteLine("Radio On {0}", turnOn);
        }
    }
}
