namespace ConsoleApp;

public class Functions
{
    public static void IntroToFunctionsFn()
    {
        Console.WriteLine("Intro to functions function :)");
    }

    public static void IntroductionFn()
    {
        Console.WriteLine("Here is an introduction of me. My name is Vlad. Hey.");
    }

    public static void HelloFn()
    {
        Console.WriteLine("Hello");
    }
    
    public static void ByeFn()
    {
        Console.WriteLine("Bye");
    }

    public static int RequestNumberFn()
    {
        Console.Write("Type number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }
        return 0;
    }

    public static int CalculateSum(int[] array)
    {
        int sum = 0;
        Array.ForEach(array, i => sum += i);
        return sum;
    }

    public static int Sum(int a, int b = 0)
    {
        return a + b;
    }

    public static bool isInitiallyTwo(ref int value)
    {
        int initialValue = value;
        value = 2;
        if (initialValue == 2)
        {
            return true;
        }

        return false;
    }
    
    public static bool TryParse(string value, out int valueParsed)
    {
        Console.WriteLine("Value passed {0}", value);
        return int.TryParse(value, out valueParsed);
    }

    public static int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
    
    public static string Add(string firstText, string secondText)
    {
        return $"{firstText}{secondText}";
    }
}

public class Section6Functions
{
    public static void IntroToFunctions()
    {
        Functions.IntroToFunctionsFn();
    }

    public static void Introduction()
    {
        Functions.IntroductionFn();
    }

    public static void HelloBye()
    {
        Functions.HelloFn();
        Console.WriteLine("Middle action");
        Functions.ByeFn();
    }
    public static void ReturnTypeMethods()
    {
        int[] array = new int[10];
        for (int i = 0; i < 10; i++)
        {
            array[i] = Functions.RequestNumberFn();
        }
        Console.WriteLine($"Sum: {Functions.CalculateSum(array)}");
    }

    public static void DefaultParameters()
    {
        Console.WriteLine(Functions.Sum(10));
    }   
    public static void NamedParameters()
    {
        void printNameAndAge(int age, string name)
        {
            Console.WriteLine($"His name is {name}, age - {age}");
        }
        
        printNameAndAge(name: "vlad", age: 29); 
    }
    
    public static void OutParameter()
    {
        int numberThree = 2;
        int numberFour = 3;
        
        Console.WriteLine(Functions.isInitiallyTwo(ref numberThree));
        Console.WriteLine(Functions.isInitiallyTwo(ref numberFour));
        
        Console.WriteLine(numberThree);
        Console.WriteLine(numberFour);
    }
    
    public static void MyOwnTryParse()
    {
        string text = "5";
        int number;
        Functions.TryParse(text, out number);
        Console.WriteLine(number);
    }   
    public static void FunctionOverloading()
    {
       Console.WriteLine(Functions.Add(10, 2));
       Console.WriteLine(Functions.Add("1", "2"));
    }
}