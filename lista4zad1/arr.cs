using System;
using ListLib;
namespace ArrayLib
{
    public class Elem
    {
        public int data;
        public Elem next;
        public Elem prev;      
        public Elem(int data)
        {
            this.data = data;
        }
    }
    
    public class Array : IList <int>
    {
        private int f_elem; //indeks ostatniego elementu tablicy
        private int l_elem; //indeks pierwszego elementu tablicy
        private int size = 0;
        
        private Elem first = null; //pierwszy element tablicy
        private Elem current_pos = null; //element do przeglądania tablicy
        private int pos_num;
        
        public int Length
        {
            get
            {
                return this.size;
            }
        }
        
        public int this [int index] //indeksowanie
        {
            get
            {
                Elem item = first;
                
                for (int i = 0; i < index; i++)
                {                                     
                    if(item == null)
                    {
                        return 0;
                    }
                    item = item.next;
                }
                
                return item.data;
            }
            
            set
            {
                Elem item = first;                
                for (int i = 0; i < index; i++)
                {

                    if(item == null)
                    {
                        return;
                    }
                    item = item.next;
                    
                }               
                item.data = value;
            }
        }
        
        public bool is_empty()
        {
            return (this.size == 0);
        }
        
        public int pop ()
        {
            return (this.get(l_elem));     
        }
        // powiększa tablicę o 1 i dodaje określony element
        public void push (int val) 
        {
            Elem pushed = new Elem (val);
            this.move (this.l_elem);
            this.current_pos.next = pushed;
            pushed.prev = this.current_pos;
            this.l_elem ++;
        }
        
        public Array(int start, int end)
        {
            this.size = end - start;
            this.pos_num = start;
            this.f_elem = start;
            this.l_elem = end;
        
            if (size > 0)
                  this.first = new Elem (0);
            
             this.create(start, end, first);
             this.current_pos = this.first;  
        }
        //tworzy zerowe elementy od indeksu start do end
        private void create (int start, int end, Elem arr)
        {
            Elem list = arr;
            for (int i = start; i < end; i ++)
            {
               list.next = new Elem(0);
               list.next.prev = list;
               list = list.next;
            }
        }
        //przesuwa current_pos na zadaną pozycję
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
          this.current_pos.data = value;   
       }
       public int get(int pos)
       {
          this.move(pos);
          return this.current_pos.data;
       }
       //zmienia rozmiar po indeksach i tworzy dodatkowe zerowe elementy
       public void resize(int start, int end)
       {
        if (start < f_elem)
        {
            Elem under = new Elem (0);
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
              Elem over = new Elem (0);
              this.create (l_elem, end, over);
              this.move (this.l_elem);
              this.current_pos.next = over;
              over.prev = this.current_pos;
              this.l_elem = end;
            }  
        this.size = this.l_elem -this.f_elem;         
        }
        
        public override string ToString()
        {
            Elem out_e = this.first;
            string output = "";
            for (int i = this.f_elem; i <= this.l_elem; i ++)
            {
                output += out_e.data + " ";
                out_e = out_e.next;
            }
            
            return output;
        }
            
    }
    
}