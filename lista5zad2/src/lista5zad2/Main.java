package lista5zad2;

import java.util.Hashtable;

public class Main 
{
	public static void main (String[] args)
	{
		Hashtable <String, Integer> tree = new Hashtable <String, Integer>();
		tree.put("x", 10);
		System.out.println("x = " + tree.get("x"));
		
		Wyrazenie w = new Operacja (new Stala(5), new Zmienna("x", tree), "+");
		System.out.println(w.toString() + " = " + w.oblicz());
		tree.put("y", 2);
		System.out.println("y = " + tree.get("y"));
		w = new Operacja(w, new Stala(4), "*");
		System.out.println(w.toString() + " = " + w.oblicz());
		w = new Operacja(w, new Zmienna("y", tree), "/");
		System.out.println(w.toString() + " = " + w.oblicz());
		
	}
}
