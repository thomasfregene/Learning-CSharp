using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter7.SimpleException
{
    public class Car_Ex
    {
        //constant for maximum speed
        public const int MaxSpeed = 100;
        //Car Properties
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        //is the car still operational
        private bool carIsDead;
        //a car has a radio
        private Radio_Ex theMusicBox = new Radio_Ex();
        //constructors
        public Car_Ex() { }
        public Car_Ex(string name, int speed)
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
            if(carIsDead)
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
                    Exception ex = new Exception(string.Format("{0} has overheated!", PetName));
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

            Car_Ex myCar = new Car_Ex("Zippy", 20);
            myCar.CrankTunes(true);

            for (int i = 0; i < 10; i++)
            {
                myCar.Accelerate(10);
            }
        }

        //Handling the thrown exception
        public static void HandlingException()
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> creating a car and stepping on it!");
            Car_Ex myCar = new Car_Ex("Zippy", 20);
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
       
    }
}
