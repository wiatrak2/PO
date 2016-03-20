namespace ListLib
{
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
    
    public class Lista <T>
    {
        private int size = 0;
        private Elem <T> first = null;
        private Elem <T> last = null;
        
        public bool is_empty()
        {
            return (this.size == 0);
        }
        
        public void push_f (T data)
        {
            Elem <T> new_elem = new Elem <T> (data);
            if (this.size == 0)
            {
                this.first = new_elem;
                this.last = new_elem;
            }
            else
            {
                new_elem.next = this.first;
                this.first.prev = new_elem;
                this.first = new_elem;
            }
            this.size ++;
        }
        
        public void push_b (T data)
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
        
        public T pop_f()
        {
            if(this.size == 0)
                return default(T);
            
            Elem <T> top = this.first;
            
            this.first = (this.size == 1) ? null : this.first.next; 
            if (this.size > 1)
                this.first.prev = null;
                
            this.size --;
            
            return top.data;
        }
        
        public T pop_b()
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
         
    }
}