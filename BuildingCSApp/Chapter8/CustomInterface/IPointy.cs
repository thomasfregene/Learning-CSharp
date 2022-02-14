using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter8.CustomInterface
{
    //This interface defines the behaviour of "having points"
    public interface IPointy
    {
        //Implicitly public and abstract
        byte Points { get; }
    }
}
