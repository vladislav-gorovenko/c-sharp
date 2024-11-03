namespace ConsoleApp;

public class Section2PrimitiveTypes
{
    public static void Numbers()
    {
        int age = 23;
        Console.WriteLine(age);
        Console.WriteLine(int.MaxValue);

        long bigNumber = 900000L;
        Console.WriteLine(bigNumber);
        Console.WriteLine($"Long: {long.MaxValue}");

        // Double - default choice, has the highest range and quite great precision.
        // Can be used for most of the cases. 
        double negative = -1.5D;
        Console.WriteLine(negative);
        Console.WriteLine($"Double: {double.MinValue}");

        // Float - used when precision doesn’t matter, eg in gaming industry,
        // where memory optimisation matters most. 
        float precision = 1.5F;
        Console.WriteLine(precision);
        Console.WriteLine($"Float: {float.MaxValue}");

        // Decimal - used in financial applications,
        // since it has a precision of around 28 signs after comma. 
        decimal money = 1.5M;
        Console.WriteLine(money);
        Console.WriteLine($"Decimal: {decimal.MaxValue}");
    }

    public static void StringsAndCharacters()
    {
        string name = "John";
        char firstLetter = 'J';
        Console.WriteLine($"first letter of {name} is {firstLetter}");
    }

    public static void ConvertFromStringToNumbers()
    {
        string intString = "1";
        int intNumber = Convert.ToInt32(intString);
        Console.WriteLine(intNumber.GetType());

        string longString = "1";
        long longNumber = Convert.ToInt64(longString);
        Console.WriteLine(longNumber.GetType());

        string doubleString = "1";
        double doubleNumber = Convert.ToDouble(doubleString);
        Console.WriteLine(doubleNumber.GetType());

        string floatString = "1";
        float floatNumber = Convert.ToSingle(floatString);
        Console.WriteLine(floatNumber.GetType());

        string decimalString = "1";
        decimal decimalNumber = Convert.ToDecimal(decimalString);
        Console.WriteLine(decimalNumber.GetType());
    }

    public static void BooleanDatatype()
    {
        bool isTrue = true;
        Console.WriteLine(isTrue);
    }

    public static void RemainderOperator()
    {
        int firstNumber = 10;
        int secondNumber = 3;
        int result = firstNumber / secondNumber;
        Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
        Console.WriteLine($"Remainder: {firstNumber % secondNumber}");
    }

    public static void VarAndConst()
    {
        const int age = 23;
        var name = "John";
        name = "Zakhar";

        Console.WriteLine($"{age} - {name}");
    }

    public static void AdvancedDataTypes()
    {
        sbyte Sbyte = 127; // -128 to 127
        byte Byte = 255; // 0 to 255

        short Short = 32767; // -32,768 to 32,767
        ushort UShort = 65535; // 0 to 65,535

        int Int = 2147483647; // -2,147,483,648 to 2,147,483,647
        uint UInt = 4294967295; // 0 to 4,294,967,295

        long Long = 9223372036854775807; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        ulong ULong = 18446744073709551615; // 0 to 18,446,744,073,709,551,615
    }

    public static void ExerciseOne()
    {
        var name = "Vladislav";
        var phoneNumber = 89992133132;
        var age = 29;
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Phone number: {phoneNumber}");
        Console.WriteLine($"Age: {age}");
    }

    public static void ExerciseTwo()
    {
        int one = 1;
        int two = 2;
        int three = 3;

        var total = one + two + three;
        var average = total / 3;
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
    }

    public static void ExerciseFour()
    {
        int firstNumber = 5;
        int secondNumber = 2;

        var remainder = firstNumber % secondNumber;
        Console.WriteLine(remainder);

        firstNumber = 4;
        remainder = firstNumber % secondNumber;
        Console.WriteLine(remainder);
    }
}