package lista5zad2;

import java.util.*;

public class Zmienna extends Wyrazenie 
{
	public String variable;
	public Hashtable<String, Integer> node;
	
	public Zmienna(String get_v, Hashtable<String, Integer> get_n)
	{
		this.variable = get_v;
		this.node = get_n;
	}

	public int oblicz() 
	{
		return node.get(variable);
	}
	
	public String toString()
	{
		return "" + variable;	
	}

}
