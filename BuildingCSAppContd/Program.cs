using BuildingCSAppContd.Chapter2;
using BuildingCSAppContd.Chapter4;
using BuildingCSAppContd.Chapter4.FunWithStrucures;
using BuildingCSAppContd.Chapter4.NullableTypes;
using BuildingCSAppContd.Chapter4.RefTypeValueTypeParams;
using BuildingCSAppContd.Chapter4.ValueAndReferenceType;
using BuildingCSAppContd.Chapter4.ValueTypeContainingRefType;
using BuildingCSAppContd.Chapter5.UnderstandingEncapsulation.CSharpClassType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd
{
    class Program
    {
        static void Main(string[] args)
        {
            //SystemEnvironmentClass.GetEnvironmentClass();
            //SystemConsoleClass.GetConsoleClass();
            //BasicDataType.LocalVArDeclaration();
            //BasicDataType.NewingDataTypes();

            //BigIntegerClass.BigIntMethod();

            //SystemBoolean.BooleanMembers();

            //SystemChar.CharMember();

            //ParsingValue.ParseFromString();

            //SystemString.EscapeCharacters();
            //SystemString.VerbatimString();
            //SystemString.StringEquality();
            //SystemString.StringsAreImmutable();
            //SystemString.BasicStringManipulation();
            //SystemString.StringInterpolation();

            //FormatingNumericalData.FormatNumericData();
            //FormatingNumericalData.DisplayMessage();

            //MembersOfNumericDataType.DataTypeFunctionality();

            //SystemText_StringBuilder.FunWithStringBuilder();

            //NarrowingAndWideningDataType.ProcessByte();
            //ImplicitlyTypedVariables.DeclareExplicitVariables();
            //ImplicitlyTypedVariables.DeclareImplicitVariables();
            //ImplicitlyTypedVariables.LinqQueryOverInt();

            //IterationConstructs.ForLoopExample();
            //IterationConstructs.ForEachLoopExample();
            //IterationConstructs.LinqQueryOverInts();
            //IterationConstructs.WhileLoopExample();
            //IterationConstructs.DoWhileLoopExample();
            //IterationConstructs.SwitchExample();
            //IterationConstructs.SwitchOnStringExample();
            //IterationConstructs.SwitchOnEnumExamples();

            //MethodsAndParameterModifiers.Add(20, 50);
            //MethodsAndParameterModifiers.ValueTypeParams();


            //MethodsAndParameterModifiers.OutParams(); 
            //MethodsAndParameterModifiers.InvokingMtdFillTheValues();
            //MethodsAndParameterModifiers.InvokinResponseMethod();
            //MethodsAndParameterModifiers.InvokingSwapStringsMtd();
            //MethodsAndParameterModifiers.InvokingCalculateAverageMtd();
            //MethodsAndParameterModifiers.InvokingDisplayFancyMessage();
            //MethodsAndParameterModifiers.InvokingOptionalParameter();

            //MethodOverload.InvokingAddMethod();

            //ArraysInCSharp.SimpleArrays();
            //ArraysInCSharp.DeclareImplicitArray();
            //ArraysInCSharp.ArrayOfObject();
            //ArraysInCSharp.RectangularMultiDimensionalArray();
            //ArraysInCSharp.JaggedMultidimensionalArray();
            //ArraysInCSharp.PassAndReceiveArrays();
            //ArraysInCSharp.SystemArrayFunctionality();

            //Bonus.BonusRequest();
            /* DayOfWeek day = DayOfWeek.Monday;
             ConsoleColor cc = ConsoleColor.Gray;
             Bonus.EvaluateEnum(EmpType3.Contractor);
             Bonus.EvaluateEnum(day);
             Bonus.EvaluateEnum(cc);*/

            /*Point p1 = new Point(340, 60);
            p1.Decrement();
            p1.Display();*/
            //Point.UseOfStruct();
            //ClassPoint.Result();
            //Point1.ValueTypeAssignment();
            //PointRef.ReferenceTypeAssignment();
            //Rectangle.ValueTypeContainingRefType();
            //Person.PassingRefTypeByValue();
            //Person.PassingRefTypesByRef();

            //DatabaseReader.ReadData();
            //DatabaseReader.NullCoalescingOperator();
            //DatabaseReader.TraditionalIfElse();
            //DatabaseReader.TesterMethod();

            //MakeCars.GetCars();

            //CarObj.CurrentState();
            //CarObj.UsingConstructorOverLoad();
            //Motorcycle.DefaultConstructorInAction();
            //Motorcycle.CustomConstructorInAction();
            //Motorcycle.ChainingConstructors();
            //Motorcycle.CtorFlow();
            Motorcycle.MakeSomeBikes();

        }

        //static int Main(string[] args)
        //{
        //    //ProccessingCmdLineArg.ProcessArguments();
        //    Console.WriteLine("Processing Command Line Argument");
        //    Console.WriteLine("Hello World");
        //    for (int i = 0; i < args.Length; i++)
        //        Console.WriteLine("Arg: {0}", args[i]);
        //    Console.ReadLine();
        //    return -1;
        //}
    }
}
