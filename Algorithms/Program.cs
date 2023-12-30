using Algorithms.SearchAlgorithms;

namespace Algorithms;

public class Program
{
    static void Main()
    {
        Console.WriteLine("QuickSortExample");
        int low = 0;
        var arr = new List<int> {6,25,1,47,9, 3,22,15};
        int high = arr.Count - 1;
        var quickSortExample = new QuickSortExample();
        quickSortExample.QuickSort(arr,  low,  high);
        string encodedArray = string.Join(",", arr);
        Console.WriteLine(encodedArray);
        Console.WriteLine("############################"); 
        
        
        
        Console.WriteLine("MergeSortExample");
        int[] array = { 12, 11, 13, 5, 6, 7 };
        int arrLength = array.Length;
        MergeSortExample mergeSort = new MergeSortExample();
        mergeSort.Sort(array,0,arrLength-1);
        Console.WriteLine("Sıralanmış dizi:");
        string encodedMergedArray = string.Join(",", array);
        Console.WriteLine(encodedMergedArray);
        Console.WriteLine("############################"); 
        
        
        
        Console.WriteLine("BinarySearchExample");
        int[] binarySearchArray = { 2, 3, 4, 10, 40 };
        int target = 10;
        BinarySearchExample bs = new BinarySearchExample();
        int result = bs.BinarySearch(binarySearchArray, target);
        if (result == -1)
            Console.WriteLine("Eleman bulunamadı.");
        else
            Console.WriteLine("Eleman " + result + ". indiste bulundu.");
        Console.WriteLine("############################"); 
        
        
        
        Console.WriteLine("LinearSearchExample");
        int[] linearSearchArray = { 12, 45, 23, 6, 18, 33 };
        int linearSearchTarget = 18;

        LinearSearchExample ls = new LinearSearchExample();
        int linearSearchResult = ls.LinearSearch(linearSearchArray, linearSearchTarget);

        if (linearSearchResult == -1)
            Console.WriteLine("Eleman bulunamadı.");
        else
            Console.WriteLine("Eleman " + linearSearchResult + ". indiste bulundu.");
        Console.WriteLine("############################"); 
    }
}