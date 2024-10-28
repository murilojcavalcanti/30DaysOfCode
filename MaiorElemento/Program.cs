int MajorityElement(int[] nums)
{
    
    int n = 0;
    Dictionary<int,int> numsRep = new Dictionary<int,int>();

    for (int i =0;i<nums.Length;i++)
    {
        if (numsRep.ContainsKey(nums[i]))
        {
            numsRep[nums[i]]++;
        }
        else
        {
            numsRep.Add(nums[i], 1);
        }

        if (i==0)
        {
            n = nums[i];
        }else  if (numsRep[nums[i]] > numsRep[n])
        {
            n = nums[i];
        }
    }
    return n;

}

Console.WriteLine(MajorityElement([6,5,5]));
