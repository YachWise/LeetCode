public class Solution
{
    public static void Main(String[] args)
    {

        int[] nums1 = { 0 };
        var m = 0;
        int[] nums2 = { 1 };
        var n = 1;
        Merge(nums1, m, nums2, n);


    }

    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {

        for (var i = 0; i < m + n; i++)
        {
            if (i >= m)
            {
                nums1[i] = nums2[i - m];
            }
        }

        Array.Sort(nums1);
    }
}