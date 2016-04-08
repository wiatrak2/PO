package lista6zad1;
import java.io.*;
import java.util.EmptyStackException;

public class List <T> implements Serializable
{

	private static final long serialVersionUID = 1L;
	private int size = 0;
	private Elem<T> first;
	private Elem<T> last;


	public List()
	{
		this.first = null;
		this.last = null;
		this.size = 0;
	}
	public List(T val)
	{
		Elem<T> new_elem = new Elem<T> (val);
		this.first = new_elem;
		this.last = new_elem;
		this.size = 1;
	}

	public void pushFront (T data)
	{
		Elem<T> new_elem = new Elem<T> (data);
		if (this.size == 0)
		{
			this.last = new_elem;
			this.first = new_elem;
	
		}
		else 
		{
			this.first.prev = new_elem;
			this.first.prev.next = this.first;
			this.first = this.first.prev;
		}
		this.size ++;
	}

	public void pushBack(T elem)
	{
		Elem<T> new_elem = new Elem<T>(elem);
		if(this.size == 0)
		{
			this.last = new_elem;
			this.first = new_elem;
		}
		else
		{
			this.last.next = new_elem;
			this.last.next.prev = this.last;
			this.last = this.last.next;
		}
		this.size++;
	}

	public T popFront() throws EmptyStackException
	{
		if (this.size == 0)
			throw new EmptyStackException();

		T ret = first.val;

		if(size == 1)
		{
			first = last = null;
		}
		else
		{
			first = first.next;
			first.prev.next = null;
			first.prev = null;
		}
		size --;
		return ret;
	}

	public T popBack ()throws EmptyStackException
	{
		if (this.size == 0)
		{
			throw new EmptyStackException();
		}				
		
		T ret = last.val;
		
		if(size == 1)
		{
			first = last = null;
		}
		else
		{
			last = last.prev;
			last.next.prev = null;
			last.next = null;
		}
		size --;
		return ret;
	}
		
	public boolean isEmpty()
	{
		return (this.size == 0);
	}

	public void print()
	{
		Elem <T> e = this.first;
		System.out.println(" " + e.val);
		while (e.next != null)
			{
				System.out.println(" " + e.next.val);
				e = e.next;
			}
		
	}
		
	private void writeObject( ObjectOutputStream out) 
			throws IOException
	{
		out.defaultWriteObject();
	}
	private void readObject(ObjectInputStream in) 
			throws IOException, ClassNotFoundException
	{
		in.defaultReadObject();
	}

}
