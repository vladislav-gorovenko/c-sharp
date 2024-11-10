using System.Text;

namespace ConsoleApp;

public class Section4String
{
    public static void Interpolation()
    {
        string name = "John";
        // @ will print things as they are, ignore escape characters
        Console.WriteLine("His name is \"{0}\"", name);
        Console.WriteLine($"His name is \"{name}\"");
        Console.WriteLine($@"His name is ""{name}""");
        Console.WriteLine("His name is " + "\"" + name + "\"");
        Console.WriteLine(string.Concat("His name is ", "\"", name, "\""));

        Console.WriteLine("PATH: C:\\Program Files\\Microsoft");
        Console.WriteLine(@"PATH: C:\Program Files\Microsoft");
    }

    public static void Empty()
    {
        Console.WriteLine(string.Empty == "");

        string name = "John";
        string name2 = new string(new char[] { 'J', 'o', 'h', 'n' });

        Console.WriteLine(name == name2);
    }

    public static void ComparisonWithEqualSignAndEqualsMethod()
    {
        Console.WriteLine(string.Empty == "");

        string name = "John";
        string name2 = new string(new char[] { 'J', 'o', 'h', 'n' });

        Console.WriteLine(name == name2);

        object nameObject = name;
        object nameObject2 = name2;

        Console.WriteLine("nameObject2 == nameObject: {0}", nameObject2 == nameObject);
        Console.WriteLine("nameObject2.Equals(nameObject): {0}", nameObject2.Equals(nameObject));
    }

    public static void Contains()
    {
        string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ";
        Console.Write("Search for: ");
        var searchInput = Console.ReadLine();
        if (searchInput != "")
        {
            Console.WriteLine("Contains {0}: {1}", searchInput, text.Contains(searchInput));
        }
        else
        {
            Console.WriteLine("Empty search.");
        }
    }

    public static void Insert()
    {
        const string someText = "Hello, ";
        Console.WriteLine(someText.Insert(someText.Length, "world"));
    }

    public static void Replace()
    {
        string featureName = "Some feature name";
        featureName = featureName.ToLower().Replace(" ", "_");
        Console.WriteLine(featureName);
    }

    public static void IndexOf()
    {
        const string text = "Hello, world! C# is awesome!";
        if (text.Contains("C#"))
        {
            int index = text.IndexOf("C#");
            Console.WriteLine("Index of C#: {0}", index);
            Console.WriteLine(text.Insert(index + 2, ","));
        }
    }

    public static void Remove()
    {
        const string textToParse = "Name:Vladislav";
        const char splitCharacter = ':';
        if (textToParse.Contains(splitCharacter))
        {
            int indexOfSplitCharacter = textToParse.IndexOf(splitCharacter);
            string field = textToParse.Remove(indexOfSplitCharacter);
            string value = textToParse.Remove(0, indexOfSplitCharacter + 1);
            Console.WriteLine("His {0} is {1}", field.ToLower(), value);
        }
    }

    public static void Substring()
    {
        const string textToParse = "Age:23";
        const char colonChar = ':';
        if (textToParse.Contains(colonChar))
        {
            int index = textToParse.IndexOf(colonChar);
            string field = textToParse.Substring(0, index);
            string value = textToParse.Substring(index + 1);
            Console.WriteLine("His {0} is {1}", field.ToLower(), value);
        }
    }

    public static void IterateOverString()
    {
        const string text = "Nastya, I love you 🥰";
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Thread.Sleep(500);
        }
    }
    
    public static void NullOrEmpty()
    {
        var text = Console.ReadLine();
        if (!String.IsNullOrEmpty(text))
        {
            Console.WriteLine("{0} is not empty", text);
        }
    }   
    public static void StringBuilder()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Vlad");
        stringBuilder.AppendLine("is me");
        Console.WriteLine(stringBuilder.ToString());
    }    
    
    public static void ExerciseOneReadStringPrintLength()
    {
        Console.Write("Type smth --> ");
        string? input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Your input's length - {0}", input.Length);
            if (input.Length >= 6)
            {
                Console.WriteLine("Your input is valid");
            }
            else
            {
                Console.WriteLine("Your input is invalid");
            }
        }
        else
        {
            Console.WriteLine("Your input is invalid");
        }
    }
    
    public static void ExerciseTwoPrintInReverse()
    {
        Console.Write("Type smth --> ");
        string? input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Normal order: {0}", input);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(input[i]);
            }
            Console.WriteLine("Reverse order: {0}", stringBuilder.ToString());
        }
        else
        {
            Console.WriteLine("Your input is invalid");
        }
    }
    public static void ExerciseThreePassword()
    {
        Console.Write("Type password: ");
        string? password = Console.ReadLine();
        Console.Write("Type password again: ");
        string? passwordConfirm = Console.ReadLine();
        if (!String.IsNullOrEmpty(password) && !String.IsNullOrEmpty(passwordConfirm))
        {
            if (password.Equals(passwordConfirm))
            {
                Console.WriteLine("Passwords are equal");
            }
            else
            {
                Console.WriteLine("Passwords do not match");
            }
        }
        else
        {
            Console.WriteLine("Please, try again");
        }
    }
}