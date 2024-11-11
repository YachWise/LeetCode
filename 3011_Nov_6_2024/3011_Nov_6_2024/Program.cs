public class Program
{
    public static void Main(String[] args)
    {

        int[] testerArr = { 5, 4, 6, 8, 10 };
        Console.Write(CanSortArray(nums: testerArr));
    }
    public static bool CanSortArray(int[] nums)
    {

        /** Solution Thought Process 

        # Small Side Bar: it's considered an easy question, personally, more of a medium question. 
        # Second Small Side Bar: the question doesn't include the ascending or descending requirements of the array, but it is ascending

        # We could be lazy and do some bubble sorting after intializing an array of the bit counts
        if we needed the array itself to be presented in the solution, I would probably look towards making it a dictionary 
        but alas, we do not, so deciding whether the bit array can be sorted with a true or false return is enough 

        # We could also not do that. 
        **/

        int previousMax = int.MinValue;
        int currentMax = nums[0];
        int currentMin = nums[0];
        int bits = ReturnBitCount(nums[0]);

        for (int i = 0; i < nums.Length; i++)
        {
            if (bits == ReturnBitCount(nums[i]))
            {
                currentMax = Math.Max(currentMax, nums[i]);
                currentMin = Math.Min(currentMin, nums[i]);
            }
            else
            {
                if (currentMin < previousMax)
                {
                    return false;
                }
                previousMax = currentMax;
                bits = ReturnBitCount(nums[i]);
                currentMin = nums[i];
                currentMax = nums[i];
            }
        }

        bool returnBool = currentMin > previousMax;

        return returnBool;


    }

    //Java solution could use Integer.bitCount, but c# isn't as blessed, so this little function should do the trick. 
    public static int ReturnBitCount(int num)
    {
        return Convert.ToString(num, 2).Replace("0", "").Length;
    }


}