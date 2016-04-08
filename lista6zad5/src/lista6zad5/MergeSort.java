package lista6zad5;

import java.util.Arrays;


public class MergeSort extends Thread
{

	public  int[] array;
	public MergeSort(int[] a)
	{
		this.array = a;
	}
	
	public void run()
	{
		mergeSort();
	}
	
    public synchronized void mergeSort()
    {
        if (array.length > 1) {
            int q = array.length/2;

            int[] leftArray = Arrays.copyOfRange(array, 0, q);
            int[] rightArray = Arrays.copyOfRange(array, q, array.length);

           MergeSort s1 = new MergeSort(leftArray);
           MergeSort s2 = new MergeSort(rightArray);
           s1.start();
           s2.start();
           try
           {
        	   s1.join();
        	   s2.join();
           }
           catch (Exception e) {}
            merge(array,leftArray,rightArray);
        }
    }

    public void merge(int[] a, int[] l, int[] r)
    {
      
    	int size = l.length + r.length;
    	int first = 0;
    	int sec = 0;
    	int index = 0;
        while (index < size)
        {
            if ((first < l.length) && (sec < r.length)) 
            {
                if (l[first] < r[sec])
                    a[index ++] = l[first ++];                    
                
                else 
                    a[index ++] = r[sec ++];                
            }
            
            else 
            {
                if (first >= l.length)
                {
                    while (sec < r.length)
                        a[index ++] = r[sec ++];
                }
                if (sec >= r.length) 
                {
                    while (first < l.length)
                        a[index ++] = l[first ++];
                }
            }
        }

    }

}