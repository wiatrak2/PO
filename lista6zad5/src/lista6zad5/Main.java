package lista6zad5;

import java.util.Arrays;

public class Main 
{
    	public static void main(String[] args)
    	{
    		int[] arr = {1,2,1,4,5,3,5,3,2,1};
            MergeSort sort = new MergeSort (arr);
            
            int q = arr.length / 2;
            
            int[] leftArray = Arrays.copyOfRange(arr, 0, q);
            int[] rightArray = Arrays.copyOfRange(arr, q, arr.length);
            
            for (int i = 0; i < q; i ++)
            {
            	System.out.print(" " + leftArray[i]);
            }
            System.out.println("");
            for (int i = q; i < arr.length; i ++)
            	System.out.print(" " + rightArray[i - q]);
            System.out.println("");
            MergeSort left = new MergeSort(leftArray);
            MergeSort right = new MergeSort(rightArray);
            
            left.start();
            right.start();
            try 
            {
            	left.join();
            	right.join();
            }
            catch (Exception e) {}
            
            for (int i = 0; i < q; i ++)
            {
            	System.out.print(" " + leftArray[i]);
            }
            System.out.println("");
            for (int i = q; i < arr.length; i ++)
            	System.out.print(" " + rightArray[i - q]);   
            
            sort.merge(arr, leftArray, rightArray);
            
            System.out.println();
            for (int i = 0; i < arr.length; i ++)
            	System.out.print(" " + arr[i]);
            System.out.println("");
            
    	}
}
