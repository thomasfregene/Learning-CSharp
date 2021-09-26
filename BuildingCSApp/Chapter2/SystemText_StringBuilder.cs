using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter2
{
    public static class SystemText_StringBuilder
    {
        public static void FunWithStringBuilder()
        {
            /*By default a StringBuilder Class is only able to initially hold 16 
             (but will expand automatically if necessary)*/
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("****Fantastic Games****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + " 2");
            sb.AppendLine("System Shock");

            Console.WriteLine(sb.ToString());

            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());

            Console.WriteLine("sb has {0} chars.", sb.Length);

            /*the default initial value can be changed via additional constructor
             as shown below
            if you append more characters than the specified limit, the StringBuilder object will
            copy its data into a new instance and grow the buffer by the specifed limit*/
            StringBuilder builder = new StringBuilder("****Fantastic Games****", 256);
        }
    }
}
