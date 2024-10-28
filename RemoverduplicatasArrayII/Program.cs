
int RemoveDuplicates(int[] nums)
{
    int count = 0;
    Dictionary<int, int> numsRep = new Dictionary<int, int>();
    
    for (int i = 0; i < nums.Length; i++)
    {
        if (numsRep.ContainsKey(nums[i]) && numsRep[nums[i]] == 0)
        {
            numsRep[nums[i]]=1;
            continue;
        }
        if (!numsRep.ContainsKey(nums[i]))
        {
            numsRep[nums[i]] = 0;
        }
    }

    foreach (int i in numsRep.Keys)
    {
        int iterator = 0;
        while (iterator <= numsRep[i] )
        {
            
                nums[count] = i;
                count++;
                iterator++;
        }

    }
    return count;

    for (int i = 0; i < nums.Length; i++)
    {
        Console.WriteLine(nums[i]);
    }
    Console.WriteLine();
    Console.WriteLine(count);
}

RemoveDuplicates([0, 0, 1, 1, 1, 1, 2, 3, 3]);