
public class QuickSortExample
{
    public  int QuickPartition(List<int> arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        //O(n) algoritma karmaşıklığı 
        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                Swap(arr,i, j);
            }
        }

        Swap(arr, i + 1, high);
        return i + 1;
    }

    public void QuickSort(List<int> arr, int low, int high)
    {
        if (low < high)
        {
            int pi = QuickPartition(arr, low, high);
//O(nlogn) algoritma karmaşıklığı

/**

*** QuickPartition da n tane veri for ile dönüldüğünde O(n) karmaşıklığı oluşur. Alttaki kodda ise böl ve fethet (divide and conquer) mantığı vardır. 

***Her bir parçayı sıralarken pivot elemanının konumuna göre diziyi böler ve alt dizileri sıralamak için kendini özyinemeli olartak çağırır.

***Her seviyede O(n) eleman üzerinde O(logn) seviyesinde bölme işlemi gerçekleştirir.

***Dolayısıyla, her bir özyineleme seviyesinde O(n) adet işlem yapılır ve bu özyinelemeler logaritmik bir şekilde devam eder. Bu durumda ortalama karmaşıklığı O(nlogn) olur.
*/
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
      
    }
    private void Swap (List<int>  arr, int i,  int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}


