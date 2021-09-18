using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd.Chapter4.NullableTypes
{
    public class CSharpNullaleType
    {
        public static void LocalNullableVariables()
        {
            //define some local nullable variable
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullablebool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInt = new int?[10];

            //Error! strings are reference types
            //string? s = "oops";
        }

        public static void LocalNullableVariableUsingNullable()
        {
            //Define some local nullable types using Nullable<T>
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInt = new Nullable<int>[10];
        }
    }
}
