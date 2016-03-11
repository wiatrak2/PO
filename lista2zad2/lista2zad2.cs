using System;

public class List 
{
   public List next;
   public List prev;
 
   public int val;
   public List (int value)
   {
       this.val = value;
   }
   public int get()
   {
       return this.val;
   }
}

public class Array
{
    private int size;
    private int f_elem;
    private int l_elem;
    
    private List first;
    private List current_pos;
    private int pos_num;
    
    public Array(int start, int end)
    {
        this.size = end - start;
        this.pos_num = start;
        this.f_elem = start;
        this.l_elem = end;
        
        if (size > 0)
            this.first = new List(0);
            
       this.create(start, end, first);
       this.current_pos = this.first;
  
    }
    
    private void create (int start, int end, List arr)
    {
        List list = arr;
        for (int i = start; i < end; i ++)
        {
            list.next = new List (0);
            list.next.prev = list;
            list = list.next;
        }
    }
    
    private void move(int pos)
    {
       if (pos_num < f_elem || pos_num >= l_elem)
        {
            this.current_pos = this.first;
            this.pos_num = this.f_elem;
        }
        
        if (pos < pos_num)
        {
            for (int i = pos_num; i > pos; i--)
            {
                 this.current_pos = this.current_pos.prev;
                 this.pos_num--;
            }
        } 
        else       
        {
              for (int i = pos_num; i < pos; i++)
              {
                  this.current_pos = this.current_pos.next;
                  this.pos_num++;             
              }
        }      
    }
    
    public void set(int pos, int value)
    {
        this.move(pos);  
        this.current_pos.val = value;   
    }
    public int get(int pos)
    {
        this.move(pos);
        return this.current_pos.val;
    }
    public int get_size()
    {
        return this.size;
    }
    public void resize(int start, int end)
    {
        if (start < f_elem)
        {
            List under = new List (0);
            this.create (start, f_elem, under);
            this.current_pos = under;
            
            for (int i = start; i < f_elem-1; i++)
                this.current_pos = this.current_pos.next;
                
            this.current_pos.next = this.first;
            this.first.prev = this.current_pos;
            this.first = under;
            this.f_elem = start;
            this.current_pos = this.first;
            this.pos_num = start;
        }         
        if (end > l_elem)
        {
            List over = new List (0);
            this.create (l_elem, end, over);
            this.move (this.l_elem);
            this.current_pos.next = over;
            over.prev = this.current_pos;
            this.l_elem = end;
        }  
        this.size = this.l_elem -this.f_elem;         
    }
}

class Program
{
    static void Main(string[] args)
    {
        Array arr1 = new Array (0, 10);
        Array arr2 = new Array (0, 10);
        Array arr3 = new Array (0, 10);
        
        for (int i = 0; i <= 10; i++)
            arr2.set(i, i);
        for (int i = 0; i <= 10; i++)
            arr3.set(i, 2 * i);
        for (int i = 0; i <= 10; i++)
            arr1.set(i, arr2.get(i) + arr3.get(i));    
            
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("arr: {0} {1} {2}", arr1.get(i), arr2.get(i), arr3.get(i));
        }
             
        Console.WriteLine("\n");
        Console.WriteLine("arr: {0} {1} {2}\n", arr1.get(0), arr2.get(0), arr3.get(0));
        
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine("arr: {0} {1} {2}", arr1.get(i), arr2.get(i), arr3.get(i));
        }
        
        Console.WriteLine("\n");
        
        arr1.resize(0, 20);
        for (int i = 11; i <= 20; i++)
        {
            arr1.set(i, arr1.get(i - 1) + arr1.get(i - 2));
            Console.WriteLine("arr1: {0}", arr1.get(i));
        }
        Console.WriteLine("arr_size: {0} {1} {2}", arr1.get_size(), arr2.get_size(), arr3.get_size());
  
    }
}