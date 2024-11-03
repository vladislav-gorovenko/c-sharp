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
}