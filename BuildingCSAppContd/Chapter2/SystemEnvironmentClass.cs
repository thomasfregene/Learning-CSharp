using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd.Chapter2
{
    public static class SystemEnvironmentClass
    {
        public static void GetEnvironmentClass()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
            Console.WriteLine("User Name: {0}", Environment.UserName);
            Console.WriteLine("System Directory: {0}", Environment.SystemDirectory);
            //Console.ReadLine();
        }
    }
}
