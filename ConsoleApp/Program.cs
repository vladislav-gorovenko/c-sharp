namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // Section 2: Primitive Types 
        RunIfEnabled(Section2PrimitiveTypes.Numbers);
        RunIfEnabled(Section2PrimitiveTypes.StringsAndCharacters);
        RunIfEnabled(Section2PrimitiveTypes.ConvertFromStringToNumbers);
        RunIfEnabled(Section2PrimitiveTypes.BooleanDatatype);
        RunIfEnabled(Section2PrimitiveTypes.RemainderOperator);
        RunIfEnabled(Section2PrimitiveTypes.RemainderOperator);
        RunIfEnabled(Section2PrimitiveTypes.VarAndConst);
        RunIfEnabled(Section2PrimitiveTypes.AdvancedDataTypes);
        RunIfEnabled(Section2PrimitiveTypes.ExerciseOne);
        RunIfEnabled(Section2PrimitiveTypes.ExerciseTwo);
        RunIfEnabled(Section2PrimitiveTypes.ExerciseFour);
        
        // Section 3: Control Flow
        RunIfEnabled(Section3ContentFlow.ConsoleInputOutput);
        RunIfEnabled(Section3ContentFlow.IfStatements);
        RunIfEnabled(Section3ContentFlow.TaskOne);
        RunIfEnabled(Section3ContentFlow.SwitchStatements);
        RunIfEnabled(Section3ContentFlow.TaskTwo);
        RunIfEnabled(Section3ContentFlow.ForLoops);
        RunIfEnabled(Section3ContentFlow.TaskThree);
        RunIfEnabled(Section3ContentFlow.WhileLoop);
        RunIfEnabled(Section3ContentFlow.GuessNumberWithWhile);
        RunIfEnabled(Section3ContentFlow.TaskFour);
        RunIfEnabled(Section3ContentFlow.ConditionOperator);
        RunIfEnabled(Section3ContentFlow.TaskFive);
        RunIfEnabled(Section3ContentFlow.StringFormat);
        RunIfEnabled(Section3ContentFlow.TaskSix);
        RunIfEnabled(Section3ContentFlow.TryParse);
        RunIfEnabled(Section3ContentFlow.TaskSeven);
        RunIfEnabled(Section3ContentFlow.ConsoleTextColorAndCustomisation);
        RunIfEnabled(Section3ContentFlow.ExerciseOneTimesTable);
        RunIfEnabled(Section3ContentFlow.ExerciseTwoAgeCheckOutput);
        RunIfEnabled(Section3ContentFlow.ExerciseFourFactorial);
        RunIfEnabled(Section3ContentFlow.ExerciseFiveFizzBuzz);
        RunIfEnabled(Section3ContentFlow.ExerciseSixBirthYear);
        RunIfEnabled(Section3ContentFlow.ExerciseSevenDaysOfTheWeek);
        RunIfEnabled(Section3ContentFlow.ExerciseEightPrintOddOrEvent);
        RunIfEnabled(Section3ContentFlow.ExerciseNineTriangle);
        RunIfEnabled(Section3ContentFlow.ExerciseThirteenOddOrEven);
        
        // Section 4: String functions
        RunIfEnabled(Section4String.Interpolation);
        RunIfEnabled(Section4String.Empty);
        RunIfEnabled(Section4String.ComparisonWithEqualSignAndEqualsMethod);
        RunIfEnabled(Section4String.Contains);
        RunIfEnabled(Section4String.Insert);
        RunIfEnabled(Section4String.Replace);
        RunIfEnabled(Section4String.IndexOf);
        RunIfEnabled(Section4String.Remove);
        RunIfEnabled(Section4String.Substring);
        RunIfEnabled(Section4String.IterateOverString);
        RunIfEnabled(Section4String.NullOrEmpty);
        RunIfEnabled(Section4String.StringBuilder);
        RunIfEnabled(Section4String.ExerciseOneReadStringPrintLength);
        RunIfEnabled(Section4String.ExerciseTwoPrintInReverse);
        RunIfEnabled(Section4String.ExerciseThreePassword);
        
        // Section 5: Data Structures
        RunIfEnabled(Section5DataStructures.StaticArrays);
        RunIfEnabled(Section5DataStructures.StaticArraysForAnglesExercise);
        RunIfEnabled(Section5DataStructures.ExerciseOneShoppingList);
        RunIfEnabled(Section5DataStructures.Sorting);
        RunIfEnabled(Section5DataStructures.SortingReverse);
        RunIfEnabled(Section5DataStructures.CopyArrays);
        RunIfEnabled(Section5DataStructures.Clear);
        RunIfEnabled(Section5DataStructures.TaskShoppingList);
        RunIfEnabled(Section5DataStructures.IndexOf);
        RunIfEnabled(Section5DataStructures.MultidimensionalArray);
        RunIfEnabled(Section5DataStructures.List);
        RunIfEnabled(Section5DataStructures.Dictonary);
        RunIfEnabled(Section5DataStructures.ExerciseDictionaryNameAge);
        RunIfEnabled(Section5DataStructures.ExerciseOneList);
        RunIfEnabled(Section5DataStructures.ExerciseTwoArrayOfMultiples);
        RunIfEnabled(Section5DataStructures.ExerciseThreeTicTacToeGame);
        
        // Section 6: Functions
        RunIfEnabled(Section6Functions.IntroToFunctions);
        RunIfEnabled(Section6Functions.Introduction);
        RunIfEnabled(Section6Functions.HelloBye);
        RunIfEnabled(Section6Functions.ReturnTypeMethods);
        RunIfEnabled(Section6Functions.DefaultParameters);
        RunIfEnabled(Section6Functions.NamedParameters);
        RunIfEnabled(Section6Functions.OutParameter);
        RunIfEnabled(Section6Functions.MyOwnTryParse);
        RunIfEnabled(Section6Functions.FunctionOverloading);
        
        // Section 7: Exception Handling
        RunIfEnabled(Section7ExceptionHandling.TryExcept);
        RunIfEnabled(Section7ExceptionHandling.ThrowingException);
        
        // Section 8: Debugging
        RunIfEnabled(Section8Debugging.Assert);
        
        // Section 9: OOP
        RunIfEnabled(Section9OOP.Struct);
        RunIfEnabled(Section9OOP.BoxStructure);
        RunIfEnabled(Section9OOP.Classes);
        RunIfEnabled(Section9OOP.JustPlaying);
        RunIfEnabled(Section9OOP.Fields);
        RunIfEnabled(Section9OOP.Overriding);
        RunIfEnabled(Section9OOP.Inheritance);
        RunIfEnabled(Section9OOP.Refreshing);
        RunIfEnabled(Section9OOP.MercedesBenz);
        RunIfEnabled(Section9OOP.PracticeEnums, true);
        
        // Algorithms
        RunIfEnabled(Algorithms.RemoveDuplicatesTask);
    }
    
    static void RunIfEnabled(Action action, bool runModule = false)
    {
        if (runModule)
        {
            action();
        }
    }
}