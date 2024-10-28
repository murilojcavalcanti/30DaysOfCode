int RemoveDuplicates(int[]nums)
{
    int count = 1;
    for (int i = 0; i <nums.Length-1; i++)
    {
        if (nums[i] == nums[i + 1])
            continue;

        nums[count] = nums[i+1];
        count++;
    }

    foreach (int i in nums)
    {
        Console.WriteLine(i);

    }
    Console.WriteLine($"elementos:{count}");

    return count;

}

RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);

