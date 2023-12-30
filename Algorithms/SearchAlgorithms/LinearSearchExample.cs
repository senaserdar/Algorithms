namespace Algorithms.SearchAlgorithms;
class LinearSearchExample
{
    public int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i; // Hedeflenen eleman bulunduğunda dizinin indeksini döndürür.
        }

        return -1; // Hedeflenen eleman bulunamadığında -1 döndürülür.
    }
}
