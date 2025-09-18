public class _2
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int pointer1 = m - 1;
        int pointer2 = n - 1;
        int len = m + n - 1;

        while (pointer2 >= 0)
        {
            if (pointer1 >= 0 && nums1[pointer1] > nums2[pointer2])
                nums1[len--] = nums1[pointer1--];
            else
                nums1[len--] = nums2[pointer2--];
        }
    }
}

/*class Program
{
    static void Main()
    {
        _2 sol = new _2();
        int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = new int[] { 2, 5, 6 };

        sol.Merge(nums1, 3, nums2, 3);
        foreach (int i in nums1) {
            Console.WriteLine(i);
        }
    }
}*/