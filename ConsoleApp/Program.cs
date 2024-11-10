namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // Section 2: Primitive Types 
        Program.RunIfEnabled(Section2PrimitiveTypes.Numbers);
        Program.RunIfEnabled(Section2PrimitiveTypes.StringsAndCharacters);
        Program.RunIfEnabled(Section2PrimitiveTypes.ConvertFromStringToNumbers);
        Program.RunIfEnabled(Section2PrimitiveTypes.BooleanDatatype);
        Program.RunIfEnabled(Section2PrimitiveTypes.RemainderOperator);
        Program.RunIfEnabled(Section2PrimitiveTypes.RemainderOperator);
        Program.RunIfEnabled(Section2PrimitiveTypes.VarAndConst);
        Program.RunIfEnabled(Section2PrimitiveTypes.AdvancedDataTypes);
        Program.RunIfEnabled(Section2PrimitiveTypes.ExerciseOne);
        Program.RunIfEnabled(Section2PrimitiveTypes.ExerciseTwo);
        Program.RunIfEnabled(Section2PrimitiveTypes.ExerciseFour);
        
        // Section 3: Control Flow
        Program.RunIfEnabled(Section3ContentFlow.ConsoleInputOutput);
        Program.RunIfEnabled(Section3ContentFlow.IfStatements);
        Program.RunIfEnabled(Section3ContentFlow.TaskOne);
        Program.RunIfEnabled(Section3ContentFlow.SwitchStatements);
        Program.RunIfEnabled(Section3ContentFlow.TaskTwo);
        Program.RunIfEnabled(Section3ContentFlow.ForLoops);
        Program.RunIfEnabled(Section3ContentFlow.TaskThree);
        Program.RunIfEnabled(Section3ContentFlow.WhileLoop);
        Program.RunIfEnabled(Section3ContentFlow.GuessNumberWithWhile);
        Program.RunIfEnabled(Section3ContentFlow.TaskFour);
        Program.RunIfEnabled(Section3ContentFlow.ConditionOperator);
        Program.RunIfEnabled(Section3ContentFlow.TaskFive);
        Program.RunIfEnabled(Section3ContentFlow.StringFormat);
        Program.RunIfEnabled(Section3ContentFlow.TaskSix);
        Program.RunIfEnabled(Section3ContentFlow.TryParse);
        Program.RunIfEnabled(Section3ContentFlow.TaskSeven);
        Program.RunIfEnabled(Section3ContentFlow.ConsoleTextColorAndCustomisation);
        Program.RunIfEnabled(Section3ContentFlow.ExerciseOneTimesTable);
        Program.RunIfEnabled(Section3ContentFlow.ExerciseTwoAgeCheckOutput);
        Program.RunIfEnabled(Section3ContentFlow.ExerciseFourFactorial);
        Program.RunIfEnabled(Section3ContentFlow.ExerciseFiveFizzBuzz);
        Program.RunIfEnabled(Section3ContentFlow.ExerciseSixBirthYear);
        Program.RunIfEnabled(Section3ContentFlow.ExerciseSevenDaysOfTheWeek);
        Program.RunIfEnabled(Section3ContentFlow.ExerciseEightPrintOddOrEvent);
        Program.RunIfEnabled(Section3ContentFlow.ExerciseNineTriangle);
        Program.RunIfEnabled(Section3ContentFlow.ExerciseThirteenOddOrEven);
        
        // Section 4: String functions
        Program.RunIfEnabled(Section4String.Interpolation);
        Program.RunIfEnabled(Section4String.Empty);
        Program.RunIfEnabled(Section4String.ComparisonWithEqualSignAndEqualsMethod);
        Program.RunIfEnabled(Section4String.Contains);
        Program.RunIfEnabled(Section4String.Insert);
        Program.RunIfEnabled(Section4String.Replace);
        Program.RunIfEnabled(Section4String.IndexOf);
        Program.RunIfEnabled(Section4String.Remove);
        Program.RunIfEnabled(Section4String.Substring);
        Program.RunIfEnabled(Section4String.IterateOverString);
        Program.RunIfEnabled(Section4String.NullOrEmpty);
        Program.RunIfEnabled(Section4String.StringBuilder);
        Program.RunIfEnabled(Section4String.ExerciseOneReadStringPrintLength);
        Program.RunIfEnabled(Section4String.ExerciseTwoPrintInReverse);
        Program.RunIfEnabled(Section4String.ExerciseThreePassword);
    }
    
    static void RunIfEnabled(Action action, bool runModule = false)
    {
        if (runModule)
        {
            action();
        }
    }
}