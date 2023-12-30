public class MergeSortExample
{
   public void Merge(int[] arr, int left, int mid, int right)
   {
      int n1 = mid - left + 1;
      int n2 = right - mid;
      int[] LeftArray = new int [n1];
      int[] RightArray = new int [n2];
      Array.Copy(arr,left,LeftArray,0,n1);
      Array.Copy(arr,mid,RightArray,0,n2);
      int i = 0, j = 0;
      int k = left;
      while (i<n1 && j<n2)
      {
         if (LeftArray[i] <= RightArray[j])
         {
            arr[k] = LeftArray[i];
            i++;
         }
         else
         {
            arr[k] = RightArray[j];
            j++;
         }

         k++;
      }
      while (i < n1)
      {
         arr[k] = LeftArray[i];
         i++;
         k++;
      }  
      while (j < n2)
      {
         arr[k] = RightArray[j];
         j++;
         k++;
      }
   }

   public void Sort(int[] arr, int left, int right)
   {
      //Algoritma karmaşıklığı O(nlogn)'dir.
      if (left < right)
      {
         int mid = left + (right - left) / 2;
         Sort(arr,left,mid);
         Sort(arr,mid+1,right);
         Merge(arr,left,mid,right);
      }
   }
   
}