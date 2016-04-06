package lista5zad1;

public abstract class St_woj implements Comparable<St_woj>
{
	public String name;
	public abstract int get_s();
	
	public int compareTo(St_woj cmp)
	{
		if (this.get_s() == cmp.get_s())
			return 0;
		if (this.get_s() > cmp.get_s())
			return 1;
		return -1;
	}
	
	public String toString()
	{
		return "stopien: " + name + " - " + this.get_s();
	}
}
