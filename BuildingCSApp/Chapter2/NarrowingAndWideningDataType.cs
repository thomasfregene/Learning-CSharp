using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter2
{
    /// <summary>
    /// implicit and explicit data conversion
    /// </summary>
    public static class NarrowingAndWideningDataType
    {
        public static void ProcessByte()
        {
            /*byte b1 = 100;
            byte b2 = 250;
            byte sum = (byte)Add(b1, b2);

            /*sum should hold the value 350. However we find the value 94
             implying a loss of data*/
           // Console.WriteLine("sum: {0}",sum);*/

            byte b1Checked = 100;
            byte b2Checked = 250;
            /*this time we tell the compiler to add CIL code 
             to throw an exception if overflow or underflow takes place*/
            try
            {
                byte sumChecked = checked((byte)Add(b1Checked, b2Checked));
                Console.WriteLine("sumChecked: {0}", sumChecked);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message); 
            }

            /*checked statement over a block of code*/
            try
            {
                checked
                {
                    byte var = (byte)Add(b1Checked, b2Checked);
                    Console.WriteLine("sumChecked: {0}", var); 
                }
            }
            catch (OverflowException ex)
            {

                Console.WriteLine(ex.Message);
            }

            /*Assuming /checked is enabled globally this block will not trigger a runtime exception*/
            unchecked
            {
                byte sumUnChecked = (byte)Add(b1Checked, b2Checked);
                Console.WriteLine("sum-UnChecked: {0}", sumUnChecked);
            }
        }

        private static int Add(int b1, int b2)
        {
            return b1 + b2;
        }
    }
}
