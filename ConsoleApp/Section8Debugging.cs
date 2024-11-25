using System.Diagnostics;

namespace ConsoleApp;

public class Section8Debugging
{
    public static void Assert()
    {
        // if 
        int a = 0;
        if (a > 18)
        {
            Console.WriteLine("a is greater than 18");
        } else if (a < 18)
        {
            Console.WriteLine("a is less than 18");
        }

        throw new Exception();
    }
}