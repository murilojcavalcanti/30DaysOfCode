void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int p1 = m - 1;
    int p2 = n - 1;
    int p3 = (m + n) - 1;
    while (p2 >= 0)
    {
        if (p1 >= 0 && nums1[p1] > nums2[p2])
        {
            nums1[p3] = nums1[p1];
            if (p3<(m + n) - 1 && nums1[p3] > nums1[p3+1])
            {
                int k = nums1[p3];
                nums1[p3] = nums1[p3 + 1];
                nums1[p3 + 1] = k;
            }
            p3--;
            p1--;
        }
        else
        {
            nums1[p3] = nums2[p2];
            if (p3 < (m + n) - 1 && nums1[p3] > nums1[p3 + 1])
            {
                int k = nums1[p3];
                nums1[p3] = nums1[p3 + 1];
                nums1[p3 + 1] = k;
            }
            p3--;
            p2--;
        }
    }
    foreach (int item in nums1)
    {
        Console.WriteLine(item);

    }

}

Merge([4, 6, 5, 0, 0, 0], 3, [3, 2, 1], 3);