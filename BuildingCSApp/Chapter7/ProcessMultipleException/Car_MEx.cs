using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter7.ProcessMultipleException
{
    public class Car_MEx
    {
        //constant for maximum speed
        public const int MaxSpeed = 100;
        //Car Properties
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        //is the car still operational
        private bool carIsDead;
        //a car has a radio
        private Radio_MEx theMusicBox = new Radio_MEx();
        //constructors
        public Car_MEx() { }
        public Car_MEx(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            //delegate request to the inner object
            theMusicBox.TurnOn(state);
        }
        //see if car has overheated
        public void Accelerate(int delta)
        {
            if (delta < 0)
                throw new ArgumentOutOfRangeException("delta", "speed must be greater than zero!");
            if (carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    //Console.WriteLine("{0} has overheated...", PetName);
                    CurrentSpeed = 0;
                    carIsDead = true;

                    //We need to call the HelpLink property, thus we need 
                    //to create a local variable before throwing the exception object
                    CarIsDeadException_MEx ex = new CarIsDeadException_MEx(string.Format("{0} has overheated!", PetName), "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "http://www.CarsRUs.com";
                    //stuffs in custom data regarding the error
                    ex.Data.Add("Timestamp", string.Format("The car exploded at {0}", DateTime.Now));
                    ex.Data.Add("Cause", "You have a lead foot");
                    throw ex;
                    //Use the "throw" keyword to raise an exception
                    /*throw new Exception(string.Format("{0} has overheated...", PetName));*/
                }
                else
                    Console.WriteLine("=> Current Speed = {0}", CurrentSpeed);
            }
        }

        public static void CarEx_SimpleException()
        {
            Console.WriteLine("***** Simple Exception example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");

            Car_MEx myCar = new Car_MEx("Zippy", 20);
            myCar.CrankTunes(true);

            for (int i = 0; i < 10; i++)
            {
                myCar.Accelerate(10);
            }
        }

        //Handling the thrown exception
        public static void HandlingException()
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            //Console.WriteLine("=> creating a car and stepping on it!");
            Car_MEx myCar = new Car_MEx("Rusty", 20);
            myCar.CrankTunes(true);
            //speed up pass the car limit go trigger the exception
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("\n*** Error! ***");
                //TargetSite actually returns a MethodBase object
                Console.WriteLine("Member Name: {0}", ex.TargetSite);
                Console.WriteLine("Class defining member: {0}", ex.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", ex.TargetSite.MemberType);

                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Source: {0}", ex.Source);

                Console.WriteLine("\n-> Custom Data:");
                foreach (DictionaryEntry de in ex.Data)
                    Console.WriteLine("{0}: {1}", de.Key, de.Value);
                //Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
            }
            Console.WriteLine("*** Out of exception range ***");
        }

        public static void HandlingMultipleException()
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car_MEx myCar = new Car_MEx("Rusty", 90);
            try
            {
                //Trip Arg out of range exception 
                //myCar.Accelerate(-10);
                myCar.Accelerate(150);
            }
            catch (CarIsDeadException_MEx e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                //attempt to open a file named carError.txt on the C drive
                FileStream fs = File.Open(@"C:\carError.txt", FileMode.Open);
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.ErrorTimeStamp);
                //Console.WriteLine(e.CauseOfError);
                //throw;
            }
            catch (ArgumentOutOfRangeException e)
            {

                try
                {
                    //attempt to open a file named carError.txt on the C drive
                    FileStream fs = File.Open(@"C:\carError.txt", FileMode.Open);
                }
                catch (Exception e2)
                {

                    Console.WriteLine(e2.Message);
                }
                Console.WriteLine(e.Message);
                //throw;
            }
            //This will catch any other exception beyond CarIsDeadException
            //or ArgumentOutOfRangeException
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                e.Data.Add("TimeStamp", string.Format($"error occurred at {DateTime.Now}"));
            }
            finally
            {
                //This will always occur. Exception or not.
                myCar.CrankTunes(false);
            }
            Console.ReadLine();
        }
    }
}