public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //first, the multiples should have a place where they are stored the best for this is to create the array, then there would have to be a loop that counts the numbers I need, then in the loop I should multiply the starting number by the index of the loop to get the multiple, then it should be saved in the array and in the last use return to give back if the result is correct

        double[] multiplos = new double[length];

        for (int i = 1; i <= length; i++)
        {
            multiplos[i - 1] = number * i;
        }

        return multiplos; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //first we have to identify the elements that will move in the list, then we save them in a list that we will build with GetRange, then we have to remove those elements from the end of the original list using RemoveRange and then we put them at the beginning using InsertRange and so we can rotate the list to the right the amount of times indicated in amount

        List<int> rule = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, rule);
    }
}
