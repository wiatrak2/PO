using System;
using ListLib;

class Program
{
    static void Main(string[] args)
    {
        ListLib.Lista<int> stack = new  ListLib.Lista<int>();
        ListLib.Lista<string> queue = new ListLib.Lista<string>();
        string data = "a";
        for (int i = 0; i < 10; i ++)
        {
            Console.WriteLine("values: {0} {1}" ,i, data); 
            stack.push_f(i);
            queue.push_b(data);
            data += "a";
        }
        Console.WriteLine("Empty: {0} {1}", stack.is_empty(), queue.is_empty());
        for (int i = 0; i < 10; i ++)
        {
            Console.WriteLine("values: {0} {1}", d   
        }
        Console.WriteLine("Empty: {0} {1}", stack.is_empty(), queue.is_empty());
        
    }
}