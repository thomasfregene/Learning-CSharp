using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter2
{
    public static class SystemChar
    {
        public static void CharMember()
        {
            Console.WriteLine("=>char type Functionality");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit: {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter: {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }
    }
}
