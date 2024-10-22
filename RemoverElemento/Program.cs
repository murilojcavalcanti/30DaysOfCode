// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int RemoveElement(int[]nums,int val)
{
    int count = 0;
    int[] nums2 = new int[nums.Length];
    for (int i = 0; i <nums.Length; i++)
    {
        if (nums[i] != val)
        {
            nums2[count] = nums[i];
            count++;
        }
    }
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = nums2[i];
    }
    
        return count;
}

RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2);