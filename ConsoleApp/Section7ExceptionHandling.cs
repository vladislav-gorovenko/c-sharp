using System.Diagnostics;

namespace ConsoleApp;

public class Section7ExceptionHandling
{
    public static void TryExcept()
    {
        bool looping = true;
        while (looping)
        {
            Console.Write("Type number: ");
            var input = Console.ReadLine();
            int number;
            try
            {
                number = Convert.ToInt32(input);
                looping = false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value you typed is too large!");
                Console.WriteLine("Type smth that is less than {0}.", Int32.MaxValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Value you typed can't be converted to Int32.");
            }

            if (!looping)
            {
                Console.WriteLine("Congratulations! Your number {0} is converted to int32", input);
            }
        }
    }

    public static bool TryFindInd(int[] array, int item, out int index)
    {
        index = -1;

        if (array.Length == 0)
        {
            throw new Exception();
        }
        
        for (int i = 0; i < array.Length; i++)
        {
            int element = array[i];
            if (element == item)
            {
                index = i;
            }
        }

        return index >= 0;
    }
    public static void ThrowingException()
    {
        int[] array = new int[0];
        int[] otherArray = new int[3] { 1, 2, 3 };
        int searchingFor = 2;
        try
        {
            if (TryFindInd(otherArray, searchingFor, out int index))
            {
                Console.WriteLine("found {0} at position {1}", searchingFor, index);
            }
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
        }
    }
}