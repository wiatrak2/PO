package lista5zad2;

public class Stala extends Wyrazenie 
{
	public int val;
	
	public Stala(int val)
	{
		this.val = val;
	}
	
	public int oblicz()
	{
		return this.val;
	}
	
	public String toString()
	{
		return "" + val;
	}

}