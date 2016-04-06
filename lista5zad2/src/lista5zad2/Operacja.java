package lista5zad2;

public class Operacja extends Wyrazenie
{
	public Wyrazenie w1;
	public Wyrazenie w2;
	public String op;
	
	public Operacja(Wyrazenie w1, Wyrazenie w2, String op)
	{
		this.w1 = w1;
		this.w2 = w2;
		this.op = op;
	}

	public int oblicz()
	{
		if (op == "+")
		{
			return w1.oblicz() + w2.oblicz();
		}
		if (op == "-")
		{
			return w1.oblicz() - w2.oblicz();
		}
		if (op == "*")
		{
			return w1.oblicz() * w2.oblicz();
		}
		if (op == "/")
		{
			return w1.oblicz() / w2.oblicz();
		}
		return 0;
	}

	public String toString()
	{
		return "(" + w1 + " " + op + " " + w2 + ")";
	}

}
