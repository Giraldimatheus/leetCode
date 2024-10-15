public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
int n = nums2.Length;
int totalLength = m + n;
int[] merged = new int[totalLength];
int i = 0, j = 0, k = 0;

while (i < m && j < n)
{
    if (nums1[i] <= nums2[j])
    {
        merged[k] = nums1[i];
        i++;
    }
    else
    {
        merged[k] = nums2[j];
        j++;
    }
    k++;
}

while (i < m)
{
    merged[k] = nums1[i];
    i++;
    k++;
}

while (j < n)
{
    merged[k] = nums2[j];
    j++;
    k++;
}

if (totalLength % 2 == 0)
{
    int midIndex = totalLength / 2;
    return (merged[midIndex - 1] + merged[midIndex]) / 2.0;
}
else
{
    int midIndex = totalLength / 2;
    return merged[midIndex];
}
    }
}