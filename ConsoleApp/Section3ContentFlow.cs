namespace ConsoleApp;

public class Section3ContentFlow
{
    public static void ConsoleInputOutput()
    {
        Console.Write("Type your name: ");
        var nameInput = Console.ReadLine();
        string name = nameInput ?? "";
        Console.Write("Type your age: ");
        var ageInput = Console.ReadLine();
        int age = ageInput != null ? Convert.ToInt16(ageInput) : 0;
        Console.WriteLine($"Hello {name}, you are {age} years old.");
    }

    public static void IfStatements()
    {
        Console.Write("Type your age: ");
        var ageInput = Console.ReadLine();
        int age = 0;
        if (int.TryParse(ageInput, out age))
        {
            if (age >= 18 && age <= 35)
            {
                Console.WriteLine("You are between 18 and 35");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are below 18");
            }
            else
            {
                Console.WriteLine("You are above 35");
            }
        }
        else
        {
            Console.WriteLine("Invalide age was provided");
        }
    }

    public static void TaskOne()
    {
        Console.Write("Type time in 24h format: ");
        var timeInput = Console.ReadLine();
        if (int.TryParse(timeInput, out int time))
        {
            if (time < 0 || time > 24)
            {
                Console.WriteLine("Invalid time was provided");
            }
            else
            {
                if (time <= 5)
                {
                    Console.WriteLine("Dawn");
                }
                else if (time <= 11)
                {
                    Console.WriteLine("Morning");
                }
                else if (time <= 17)
                {
                    Console.WriteLine("Afternoon");
                }
                else if (time <= 23)
                {
                    Console.WriteLine("Evening");
                }
            }
        }
    }

    public static void SwitchStatements()
    {
        Console.Write("Type day of the week number: ");
        const string errorMsg = "Invalid day was provided";
        var dayInput = Console.ReadLine();
        if (int.TryParse(dayInput, out int day))
        {
            if (day >= 1 && day <= 7)
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                    case 5:
                        Console.WriteLine("Thursday or Friday");
                        break;
                    default:
                        Console.WriteLine("Weekend");
                        break;
                }
            }
            else
            {
                Console.WriteLine(errorMsg);
            }
        }
        else
        {
            Console.WriteLine(errorMsg);
        }
    }

    public static void TaskTwo()
    {
        Console.Write("Type character: ");
        var charInput = Console.ReadKey();
        char keyChar = charInput.KeyChar;
        keyChar = char.ToLower(keyChar);
        Console.WriteLine("");
        switch (keyChar)
        {
            case 'a':
                Console.WriteLine("Excellent!");
                break;
            case 'b':
                Console.WriteLine("Very good!");
                break;
            case 'c':
                Console.WriteLine("Good!");
                break;
            case 'd':
                Console.WriteLine("Pass!");
                break;
            default:
                Console.WriteLine("Unknown grade");
                break;
        }
    }

    public static void ForLoops()
    {
        Console.Write("Type number of iterations: ");
        const string ERROR_MSG = "Invalid number of iterations was provided";
        var userInput = Console.ReadLine();
        Console.WriteLine("");
        if (int.TryParse(userInput, out int iterations))
        {
            switch (iterations)
            {
                case < 100:
                    for (int i = 0; i < iterations; i++)
                    {
                        Console.WriteLine($"Iteration number: {i + 1}");
                    }

                    break;
                default:
                    Console.WriteLine("Too many iterations were provided");
                    break;
            }
        }
        else
        {
            Console.WriteLine(ERROR_MSG);
        }
    }

    public static void TaskThree()
    {
        int total = 0;
        for (int i = 1; i <= 10; i++)
        {
            total += i;
        }

        Console.WriteLine($"Total of 1+..+10: {total}");
    }

    public static void WhileLoop()
    {
        int total = 0;
        while (total <= 1000)
        {
            total++;
            Console.WriteLine($"Item: {total}");
        }
    }

    public static void GuessNumberWithWhile()
    {
        int number = new Random().Next(1, 6);
        int guess = 0;
        while (guess != number)
        {
            Console.Write("Guess the number: ");
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess != number)
                {
                    Console.WriteLine("Close, try again");
                }
            }
            else
            {
                Console.WriteLine("Type valid number");
            }
        }

        Console.WriteLine("You guessed the number! It's {0}.", number);
    }

    public static void TaskFour()
    {
        const string ERROR_MSG = "Invalid choice was provided. Try again.";
        Console.WriteLine("There are 3 options, namely:");
        Console.WriteLine("1. Buy");
        Console.WriteLine("2. Sell");
        Console.WriteLine("3. Swap");
        int userChoice = 0;
        while (userChoice < 1 || userChoice > 3)
        {
            Console.WriteLine("Choose one of the options: ");
            var userChoiceInput = Console.ReadLine();
            if (int.TryParse(userChoiceInput, out userChoice))
            {
                if (userChoice < 1 && userChoice > 3)
                {
                    Console.WriteLine(ERROR_MSG);
                }
            }
            else
            {
                Console.WriteLine(ERROR_MSG);
            }
        }

        Console.WriteLine("Well done. You have chosen option {0}.", userChoice);
    }

    public static void ConditionOperator()
    {
        int age = -10;
        string condition = age > 0 ? "Valid age" : "Invalid age";
        Console.WriteLine(condition);
    }

    public static void TaskFive()
    {
        Console.Write("Type first number: ");
        var firstNumberInput = Console.ReadLine();
        Console.Write("Type second number: ");
        var secondNumberInput = Console.ReadLine();
        if (int.TryParse(firstNumberInput, out int firstNumber) &&
            int.TryParse(secondNumberInput, out int secondNumber))
        {
            Console.WriteLine("First number: {0}, Second number: {1}", firstNumber, secondNumber);
            Console.WriteLine("The largest one is: {0}", firstNumber > secondNumber ? firstNumber : secondNumber);
        }
        else
        {
            Console.WriteLine("Invalid numbers were provided");
        }
    }

    public static void StringFormat()
    {
        double price = 10.123123;
        Console.WriteLine("Price: {0:0.000}", price);
        Console.WriteLine("Price: {0:0.#}", price);
        Console.WriteLine(price.ToString("C3", new System.Globalization.CultureInfo("en-US")));
    }

    public static void TaskSix()
    {
        string amountInput;
        double amount;
        do
        {
            Console.Write("Type amount of USD you wish you had just now: ");
            amountInput = Console.ReadLine() ?? "";
        } while (!double.TryParse(amountInput, out amount));

        string amountString = amount.ToString("C2", new System.Globalization.CultureInfo("en-US"));
        Console.WriteLine("You decided to have {0} USD.", amountString);
    }

    public static void TryParse()
    {
        int age;
        bool isSuccess = int.TryParse("as", out age);
        Console.WriteLine(age);
    }

    public static void TaskSeven()
    {
        int age;
        string ageInput;
        Console.Write("Type your age: ");
        ageInput = Console.ReadLine() ?? "";
        while (!int.TryParse(ageInput, out age) || age < 0 || age > 125)
        {
            if (int.TryParse(ageInput, out age))
            {
                if (age < 0 || age > 125)
                {
                    Console.WriteLine("Invalid age range: {0}", age);
                }
            }
            else
            {
                Console.WriteLine("Invalid age was provided");
            }

            Console.Write("Type your age: ");
            ageInput = Console.ReadLine() ?? "";
        }

        Console.WriteLine("Valid age was provided: {0}", age);
    }

    public static void ConsoleTextColorAndCustomisation()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Het");
    }

    public static void ExerciseOneTimesTable()
    {
        Console.Write("Type number: ");
        var numberInput = Console.ReadLine();
        if (int.TryParse(numberInput, out int number))
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }
        }
        else
        {
            Console.WriteLine("Number is invalid");
        }
    }

    public static void ExerciseTwoAgeCheckOutput()
    {
        Console.Write("Input your age: ");
        var ageInput = Console.ReadLine();
        if (int.TryParse(ageInput, out int age))
        {
            switch (age)
            {
                case int a when a < 0 || a > 125:
                    Console.WriteLine("Invalid age was provided");
                    break;
                case <= 11:
                    Console.WriteLine("Child");
                    break;
                case <= 18:
                    Console.WriteLine("Teenager");
                    break;
                case <= 59:
                    Console.WriteLine("Adult");
                    break;
                default:
                    Console.WriteLine("Senior Adult");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Failed to parse age.");
        }
    }

    public static void ExerciseFourFactorial()
    {
        Console.Write("Type number: ");
        var numberInput = Console.ReadLine();
        if (int.TryParse(numberInput, out int number))
        {
            int result = 1;
            while (number > 0)
            {
                result *= number;
                Console.WriteLine("Current number: {0}, Result: {1}", number, result);
                number--;
            }

            Console.WriteLine("Total: {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid number was provided");
        }
    }

    public static void ExerciseFiveFizzBuzz()
    {
        Console.Write("Type number: ");
        var numberInput = Console.ReadLine();
        if (int.TryParse(numberInput, out int number))
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("{0} - FizzBuzz", i);
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("{0} - Fizz", i);
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("{0} - Buzz", i);
                    }
                    else
                    {
                        Console.WriteLine("{0}", i);
                    }
                }
            }
        }
    }

    public static void ExerciseSixBirthYear()
    {
        Console.Write("Type year you were born: ");
        var yearBornInput = Console.ReadLine();
        Console.Write("Type current year: ");
        var yearNowInput = Console.ReadLine();
        if (int.TryParse(yearBornInput, out int yearBorn) && int.TryParse(yearNowInput, out int yearNow))
        {
            Console.WriteLine("Year born: {0}", yearBorn);
            Console.WriteLine("Year now: {0}", yearNow);
            Console.WriteLine("Lived aproximately: {0}", (yearNow - yearBorn) * 365);
        }
    }

    public static void ExerciseSevenDaysOfTheWeek()
    {
        Console.Write("Enter the day of the week: ");
        var dayInput = Console.ReadLine();
        if (int.TryParse(dayInput, out int day))
        {
            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day is provided");
            }
            else
            {
                string dayString;
                switch (day)
                {
                    case 1:
                        dayString = "Monday";
                        break;
                    case 2:
                        dayString = "Tuesday";
                        break;
                    case 3:
                        dayString = "Wednesday";
                        break;
                    case 4:
                        dayString = "Thursday";
                        break;
                    case 5:
                        dayString = "Friday";
                        break;
                    case 6:
                        dayString = "Saturday";
                        break;
                    default:
                        dayString = "Sunday";
                        break;
                }

                Console.WriteLine("The day is {0}", dayString);
            }
        }
    }

    public static void ExerciseEightPrintOddOrEvent()
    {
        Console.Write("Type odd or even: ");
        var userInput = Console.ReadLine();
        if (!string.IsNullOrEmpty(userInput))
        {
            switch (userInput)
            {
                case "odd":
                    break;
                case "even":
                    Console.WriteLine("Even");
                    break;
                default:
                    Console.WriteLine("Wrong input provided");
                    return;
            }

            for (int i = 1; i <= 100; i++)
            {
                if (userInput == "even")
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    if (userInput == "odd")
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No input provided");
        }
    }

    public static void ExerciseNineTriangle()
    {
        Console.Write("Enter first angle: ");
        var firstAngleInput = Console.ReadLine();
        Console.Write("Enter second angle: ");
        var secondAngleInput = Console.ReadLine();
        Console.Write("Enter third angle: ");
        var thirdAngleInput = Console.ReadLine();
        if (int.TryParse(firstAngleInput, out int firstAngle)
            && int.TryParse(secondAngleInput, out int secondAngle)
            && int.TryParse(thirdAngleInput, out int thirdAngle))
        {
            int sum = firstAngle + secondAngle + thirdAngle;
            bool isValid = sum == 180;
            string result = isValid ? "Valid triangle" : "Invalid triangle";
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }

    public static void ExerciseThirteenOddOrEven()
    {
        Console.Write("Type number: ");
        var numberInput = Console.ReadLine();
        if (int.TryParse(numberInput, out int number))
        {
            Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
        }
    }
}