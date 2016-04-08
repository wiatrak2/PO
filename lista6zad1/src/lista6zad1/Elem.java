package lista6zad1;
import java.io.*;
import java.io.Serializable;

public class Elem <T> implements Serializable
{

	private static final long serialVersionUID = 1L;
	T val = null;
	Elem <T> next = null;
	Elem <T> prev = null;

	Elem(T val)
	
	{
		this.val = val;
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
