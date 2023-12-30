namespace Algorithms.SearchAlgorithms;

class BinarySearchExample
{
    public int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
//Binary Search'ün  Algoritma karmaşası O(logn)'dir. Böl ve fethet (divide and conquer) mantığı vardır. 
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}
