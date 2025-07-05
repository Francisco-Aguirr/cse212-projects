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

        // Implementation Plan:
        // 1. Create a new array of doubles with the specified length
        // 2. Use a for loop to iterate from 0 to length-1
        // 3. For each index i, calculate the multiple as number multiplied by (i+1)
        // 4. Store the result in the array at position i
        // 5. Return the completed array

        double[] result = new double[length]; // Step 1: Create array of specified length
        
        for (int i = 0; i < length; i++) // Step 2: Loop through each index
        {
            result[i] = number * (i + 1); // Step 3-4: Calculate and store the multiple
        }
        
        return result; // Step 5: Return the completed array
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

        // Implementation Plan:
        // 1. Calculate the split point where the rotation will occur (data.Count - amount)
        // 2. Get the right part of the list that will be moved to the front (using GetRange)
        // 3. Get the left part of the list that will be moved to the back (using GetRange)
        // 4. Clear the original list
        // 5. Add the right part first (that was originally at the end)
        // 6. Then add the left part (that was originally at the beginning)

        // Edge case: if amount equals list length, no rotation needed
        if (amount == data.Count)
        {
            return;
        }

        // Step 1: Calculate the split point
        int splitPoint = data.Count - amount;
        
        // Step 2: Get the right part that needs to move to front
        List<int> rightPart = data.GetRange(splitPoint, amount);
        
        // Step 3: Get the left part that needs to move to back
        List<int> leftPart = data.GetRange(0, splitPoint);
        
        // Step 4: Clear the original list
        data.Clear();
        
        // Step 5: Add the right part first
        data.AddRange(rightPart);
        
        // Step 6: Add the left part after
        data.AddRange(leftPart);
    }
}
