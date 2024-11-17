namespace ConsoleApp;

public class Section5DataStructures
{
    public static void StaticArrays()
    {
        int[] array = new int[3];
        int currentIndex = 0;
        Array.ForEach(new int[3], (element) =>
        {
            Console.Write("Type number: ");
            string? input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                array[currentIndex] = number;
                currentIndex++;
            }
        });
        int sum = 0;
        foreach (int i in array)
        {
            sum = sum + i;
        }

        ;
        Console.WriteLine("Sum: {0}", sum);
    }

    public static void StaticArraysForAnglesExercise()
    {
        int[] angles = new int[3];
        int validAttempts = 0;

        while (validAttempts <= 2)
        {
            Console.Write("Type number: ");
            string? input = Console.ReadLine();
            int currentValue;

            if (int.TryParse(input, out currentValue))
            {
                Console.WriteLine(currentValue);
                angles[validAttempts] = currentValue;
                validAttempts++;
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }

        int sum = 0;
        foreach (int angle in angles)
        {
            sum += angle;
        }

        if (sum == 180)
        {
            Console.WriteLine("Valid triangle");
        }
        else
        {
            Console.WriteLine("Not valid triangle");
        }
    }

    public static void ExerciseOneShoppingList()
    {
        string[] shoppingList = new string[4];

        shoppingList[0] = "first item";
        shoppingList[1] = "second item";
        shoppingList[2] = "third item";
        shoppingList[3] = "fourth item";

        foreach (string item in shoppingList)
        {
            Console.Write(item);
        }

        Array.ForEach(shoppingList, i => Console.Write(i));

        for (int i = 0; i < shoppingList.Length; i++)
        {
            Console.Write(shoppingList[i]);
        }
    }

    public static void Sorting()
    {
        string[] shoppingList = new string[]
        {
            "Coffee",
            "Water",
            "Bread",
            "Smth else"
        };
        foreach (string item in shoppingList)
        {
            Console.Write("{0}", item);
        }
        Console.Clear();
    }

    public static void SortingReverse()
    {
        string[] shoppingList = new string[]
        {
            "Coffee",
            "Water",
            "Bread",
            "Smth else"
        };
        shoppingList.Reverse();

        int index = 1;
        foreach (string item in shoppingList)
        {
            Console.Write("{0} - {1}{2}", index, item, Environment.NewLine);
            index++;
        }

        for (int i = 0; i < shoppingList.Length; i++)
        {
            Console.WriteLine("{0} - {1}", i + 1, shoppingList[i]);
        }
    }

    public static void CopyArrays()
    {
        string[] numbers = new[] { "first", "second", "third" };
        string[] newNumbers = numbers;
        newNumbers[1] = "not second";
        Console.WriteLine(numbers[1]);
        string[] copiedNumbers = new string [numbers.Length];
        Array.Copy(numbers, copiedNumbers, copiedNumbers.Length);
        copiedNumbers[1] = "second";
        Console.WriteLine(copiedNumbers[1]);
        Console.WriteLine(numbers[1]);
    }

    public static void Clear()
    {
        string[] numbers = new[] { "first", "second", "third" };
        Array.Clear(numbers, 1, 1);
        foreach (string item in numbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("{0} item", numbers[1]);
    }

    public static void TaskShoppingList()
    {
        string[] shoppingList = new string [5]
        {
            "First item",
            "Second item",
            "Third item",
            "Fourth item",
            "Fiveth item",
        };
        Array.Clear(shoppingList, 1, 4);
        int index = 0;
        foreach (string item in shoppingList)
        {
            index++;
            if (!String.IsNullOrEmpty(item))
            {
                Console.WriteLine("Item {0} - {1}", index, item);
            }
        }
    }
    public static void IndexOf()
    {
        int[] someArray = new[] { 1, 2, 3, 4, 5, 99, 55, 66 };
        string searchForValue(int[] array, int value) 
        {
            int index = Array.IndexOf(array, value);
            if (index > -1)
            {
                return $"{value} was found at position {index}";
            }
            else
            {
                return $"{value} was not found in array";
            }
        }
        Console.WriteLine(searchForValue(someArray, 55));
        Console.WriteLine(searchForValue(someArray, 66));
        Console.WriteLine(searchForValue(someArray, 123));
    } 
    public static void MultidimensionalArray()
    {
        char x = 'X';
        char [,] array = new char[3, 3]
        {
            { x, x, x },
            { x, x, x },
            { x, x, x }
        };
        array[0, 0] = 'O';
        array[1, 1] = 'O';
        array[2, 2] = 'O';
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.Write(Environment.NewLine);
        }
    }
    public static void List()
    {
        List<char> charList = new List<char>(1)
        {
            'x'
        };
        charList.Add('o');
        charList.ForEach(item => Console.WriteLine(item));
    }    
    public static void Dictonary()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>()
        {
            { "First product", 100 },
            { "Second product", 200 }
        };
        dictionary["Third Product"] = 300;
        if (dictionary.TryGetValue("sda product", out int number))
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("Item not found");
        }

        foreach (KeyValuePair<string, int> item in dictionary)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
    public static void ExerciseDictionaryNameAge()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "Vladislav", 29 },
            { "Zakhar", 20 }
        };
        // 1. checking if such name exists 
        Console.Write("Search for name: ");
        var nameSearch = Console.ReadLine()?.ToLower();
        if (!String.IsNullOrEmpty(nameSearch))
        {
            if (dictionary.ContainsKey(nameSearch))
            {
                Console.WriteLine("Name {0} found", nameSearch);
            }
            else
            {
                Console.WriteLine("Name {0} not found", nameSearch);
            }
        }
        Console.Read();
        Console.Clear();
        
        // 2. adding new entry 
        Console.Write("Enter name: ");
        var nameEnter = Console.ReadLine();
        Console.Write("Enter age: ");
        var age = Console.ReadLine();
        if (!String.IsNullOrEmpty(nameEnter))
        {
            if (dictionary.ContainsKey(nameEnter.ToLower()))
            {
                Console.WriteLine("Name {0} already exists", nameEnter);
            }
            else if (int.TryParse(age, out int parsedAge))
            {
                dictionary[nameEnter] = parsedAge;
            }
        }

        foreach (KeyValuePair<string, int> item in dictionary)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
        Console.ReadLine();
        Console.Clear();
        
        // 3. removing entry 
        Console.WriteLine("Enter name: ");
        var nameDelete = Console.ReadLine();
        if (!String.IsNullOrEmpty(nameDelete))
        {
            if (dictionary.Remove(nameDelete))
            {
                Console.WriteLine($"Name {nameDelete} removed");
            }
        }
        else
        {
            Console.WriteLine($"Name {nameDelete} doesn't exist");
        }

        foreach (KeyValuePair<string, int> item in dictionary)
        {
            Console.WriteLine(item);
        }
    }
    public static void ExerciseOneList()
    {
        List<int> even = new List<int>();
        List<int> odd = new List<int>();
        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                even.Add(i);
            }
            else
            {
                odd.Add(i);
            }
        }
        Console.Write($"even: ");
        even.ForEach(i => Console.Write($"{i} "));
        Console.WriteLine();
        Console.Write($"odd: ");
        odd.ForEach(i => Console.Write($"{i} "));
    }
    
    public static void ExerciseTwoArrayOfMultiples()
    {
        int[] initArray(int num, int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = num * (i + 1);
            }

            return array;
        }

        int[] someArray = initArray(7, 7);
        Array.ForEach(someArray, (i) => Console.WriteLine(i));
    }  

    public static void ExerciseThreeTicTacToeGame()
    {
        char[,] board = new char[3, 3]
        {
            { 'O', 'X', 'X' },
            { 'X', 'O', 'X' },
            { 'X', 'X', 'O' },
        };
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write($"{board[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    
}