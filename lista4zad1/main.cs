using System;
using ArrayLib;
using ListLib;

class Program
{
    static void Main(string[] args)
    {
        ArrayLib.Array arr = new ArrayLib.Array(0, 10);
        //sprawdzenie indeksowania
        for (int i = 0; i < 10; i ++)
        {
            arr[i] = i * i;
        }
        //sprawdzenie push
        for (int i = 0; i < 10; i ++)
        {
            arr.push(i);
        }
        //sprawdzenie resize
        arr.resize(0, 30);
        for (int i = 21; i <= 30; i ++)
        {
            arr.set(i, arr.get(i - 1) + arr.get(i - 2));
        }
        //sprawdzenie ToString
        Console.WriteLine(arr);
        
        //sprawdzenie Length
        Console.WriteLine("{0}", arr.Length);
        
        //sprawdzenie list
        ListLib.List <string> list = new ListLib.List <string>();
        string data = "a";
        
        for (int i = 0; i < 10; i ++)
        {
           list.push(data);
           data += ((char)(i + 98));           
        }
        
        for (int i = 0; i < 10; i ++)
        {
            Console.WriteLine("{0}", list.pop());
        }
        
        //IEnumerable
        ListLib.List <int> enumerable = new ListLib.List <int> ();
      
        for (int i = 0; i < 5; i ++)
            enumerable.push(i);
        
        foreach (int i in enumerable)
        {
            Console.WriteLine(i);
        }
        
    }
}