using System;
using System.Collections;
namespace ListLib
{
    
public interface IList <T>
{
    void push (T elem);
    T pop ();
    bool is_empty();
}

    public class Elem <T>
    {
        public T data;
        public Elem <T> next;
        public Elem <T> prev;      
        public Elem(T data)
        {
            this.data = data;
        }
    }
   
    public class List <T> : IList <T>, IEnumerable
    {
        private int size = 0;
        private Elem <T> first = null;
        private Elem <T> last = null;
        
        public bool is_empty()
        {
            return (this.size == 0);
        }
        
        public void push (T data)
        {
            Elem <T> new_elem = new Elem <T> (data);
            if (this.size == 0)
            {
                this.first = new_elem;
                this.last = new_elem;
            }
            else
            {
                new_elem.prev = this.last;
                this.last.next = new_elem;
                this.last = new_elem;
            }
            this.size ++;
        }
        
        public T pop()
        {
            if(this.size == 0)
                return default(T);
            
            Elem <T> top = this.last;
            
            this.last = (this.size == 1)? null : this.last.prev;
            if (this.size > 1)
                this.last.next = null;
                
            this.size --;
            
            return top.data;
        } 
        
       public IEnumerator GetEnumerator()
        {
            return new ListEnum <T> (first); 
        }
           
             
    }
    
    public class ListEnum <T> : IEnumerator
    {
        Elem <T> elem_data;
        
        public ListEnum (Elem <T> data)
        {
            this.elem_data = data;
        }
        
        public bool MoveNext()
        {
            if (this.elem_data == null)
                return false;
            this.elem_data = this.elem_data.next;
            return this.elem_data != null;
        }
        
        public object Current
        {   
            get
             {
                return this.elem_data.data;
             }
        }
        
        public void Reset()
        {
            this.elem_data.next = null;
            this.elem_data.prev = null;
        }            
    }
    
    
   
}