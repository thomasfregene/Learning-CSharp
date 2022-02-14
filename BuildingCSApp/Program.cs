using BuildingCSApp.Chapter4.FunWithStrucures;
using BuildingCSApp.Chapter5.Inheritance.Has_ARelationship;
using BuildingCSApp.Chapter5.UnderstandingEncapsulation.CSharpClassType;
//using BuildingCSApp.Chapter5.UnderstandingEncapsulation.EmployeeApp;
using BuildingCSApp.Chapter5.UnderstandingEncapsulation.ObjectInitializer;
using BuildingCSApp.Chapter5.UnderstandingEncapsulation.StaticDataAndMemebers;
using BuildingCSApp.Chapter5.UnderstandingEncapsulation.StaticDataAndMemebers.SimpleUtilityClass;
using BuildingCSApp.Chapter6.BasicInheritance;
using BuildingCSApp.Chapter6.NestedTypes;
using BuildingCSApp.Chapter6.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingCSApp.Chapter6.Shapes;
using BuildingCSApp.Chapter6;
using BuildingCSApp.Chapter7.SimpleException;
using BuildingCSApp.Chapter7.CustomException;
using BuildingCSApp.Chapter7.ProcessMultipleException;
using BuildingCSApp.Chapter8.ICloneableExample;

namespace BuildingCSApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Obtain Error Code");
            //Console.WriteLine();
            ////Console.ReadLine();
            //return -1;
            //SavingsAccount.AccountBal();

            //SavingsAccount.AccountBal2();
            //SavingsAccount.AcoountBal3();
            //TimeUtilClass.PrintDateAndTime();
            //Car.CarRadio();

            //Employee.TestEmployeeApp();
            //Employee.TestEmployeeAppWithPpty();
            //Employee.IncreamentAgeOnBirthday();
            //CarObj.UsingAutomaticProp();
            //Garage.DefaultValue();
            //PointObj.ObjInitializerSyntax();
            //Rectangle.ObjInitRect();

            //Car_Ihr.CarProp();
            //MiniVan.Car_MiniVan();

            //create and use the public inner class OK!
            /*OuterClass.PublicInnerClass innerClass;
            innerClass = new OuterClass.PublicInnerClass();*/

            //Define benefit Level
            //nested type
            /*
            Employee_Ihr.BenefitPackage.BenefitPackageLevel myBenefitLevel
                = Employee_Ihr.BenefitPackage.BenefitPackageLevel.Plantinum;
            Console.WriteLine(myBenefitLevel);
            */

            //SalesPerson_Ihr.EmployeeSalesPerson();
            //Manager_Ihr.Employee_Manager();

            //Error! cannot create an instance of an abstract class
            //Employee_Ihr employee = new Employee_Ihr();

            //Hexagon.Hex();
            //Circle.Cir();
            //Shape.Shape_Astract();
            //ThreeDCircle.ThreeDCircle_Status();
            //AsKeyword.UsingAsKeyword();
            //Employee_Ihr.TestPromotionMethod();
            //Person.SystemObjectMethod();

            //Car_Ex.CarEx_SimpleException();
            //Car_Ex.HandlingException();
            //Car_SEx.HandlingExWithCustomException();

            //Car_MEx.HandlingMultipleException();

            CloneableIntefaceExample.ExampleMethod();
        }
    }
}
