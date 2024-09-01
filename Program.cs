using System;

namespace typeConversionsPractic
{
    class TypeConversionsPractic
    {
        static void Main(string[] args)
        {
            short shortResoult, shortVal = 4;
            int integerVal = 67;
            long longResoult;
            float floatVal = 10.5f;
            double doubleResoult, doubleVal = 99.999;
            string stringResoult, stringVal = "17";
            bool boolVal = true;
            Console.WriteLine("Variable Conversion Examples\n");
            doubleResoult = floatVal * shortVal;
            Console.WriteLine($"Implicit, -> double: {floatVal} * {shortVal} -> {doubleResoult}");
            shortResoult = (short)floatVal;
            Console.WriteLine($"Explicit, -> short: {floatVal} -> {shortResoult}");
            stringResoult = Convert.ToString(boolVal) + Convert.ToString(doubleVal);
            Console.WriteLine($"Explicit, -> string: \"{boolVal}\"+\"{doubleVal}\" -> " + $"{stringResoult}");
            longResoult = integerVal + Convert.ToInt64(stringVal);
            Console.WriteLine($"Mixed, -> long: {integerVal} + {stringVal} -> {longResoult}");
            Console.ReadKey();
        }
    }

}