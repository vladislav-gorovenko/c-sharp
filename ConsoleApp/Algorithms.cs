namespace ConsoleApp;

public class Algorithms
{
    public static int RemoveDuplicates(int[] nums)
    {
        int DEFAULT_VALUE = 0;
        int leftPointer = 1; 

        for (int rightPointer = 1; rightPointer < nums.Length; rightPointer++) {
            if (nums[rightPointer] != nums[rightPointer - 1]) {
                nums[leftPointer++] = nums[rightPointer];
            }
        }

        for (int index = nums.Length - 1; index > leftPointer - 1; index--) {
            nums[index] = DEFAULT_VALUE;
        }

        return leftPointer; 
    }
    
    public static void RemoveDuplicatesTask()
    {
        int[] array = { 0,0,1,1,1,2,2,3,3,4 };
        RemoveDuplicates(array);
        Console.WriteLine(string.Join(", ", array));
    }
}