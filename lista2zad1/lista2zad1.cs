using System;
public class IntStream
{
    protected int stream_val;
    public virtual int next()
    {
        if (this.stream_val == int.MaxValue)
            {
                this.stream_val = -1;
                return -1;
            }
        this.stream_val++;
        return this.stream_val;
    }
    public virtual bool eos()
    {
        return (this.stream_val == int.MaxValue || this.stream_val == -1);
    }
    public void reset()
    {
        this.stream_val = -1;
    }
}

public class PrimeStream: IntStream
{
    private int sqrt_max = (int)Math.Sqrt(int.MaxValue);
    protected int next_prim()
    {
        if (stream_val < 2)
            return 2;
        for (int i = stream_val + 1; i <= this.sqrt_max; i++)
          {
              bool guard = false;
              for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                     if (i % j == 0)
                        {
                            guard = true;
                            break;
                        }
                }
                if (guard == false)
                    return i;
          }
        return 0;
    }
    
    public override int next()
    {
        if(next_prim() == 0)
            {
                stream_val = -1;
                return stream_val;
            }
         stream_val = next_prim();
         return stream_val;
    }
}

public class RandomStream: IntStream
{
    Random rand = new Random();
    public override bool eos()
    {
        return false;
    }
    public override int next()
    { 
        return rand.Next(int.MaxValue);       
    }
}

public class RandomWordStream: PrimeStream
{
    RandomStream rand = new RandomStream();
    public new string next()
    {
        stream_val = next_prim();
        string word = "";

        
        for (int i = 0; i < stream_val; i++)
        {
            word += (char)((rand.next() % 26) + 97);
        }
        return word;
    }   
}

class Program
{
	static void Main(string[] args)
	{
		IntStream stream = new IntStream();
        PrimeStream prime = new PrimeStream();
        RandomStream random = new RandomStream();
        RandomWordStream rand_word = new RandomWordStream();
 
        Console.WriteLine("stream_number: {0}", stream.next());
        Console.WriteLine("stream_number: {0}", stream.next());
        Console.WriteLine("stream_number: {0}", stream.next());
        for (int i = 1; i < 10000; i++)
            stream.next();
        Console.WriteLine("stream_number + 10000: {0}\n", stream.next());
        Console.WriteLine("prime_number: {0}", prime.next());
        Console.WriteLine("prime_number: {0}", prime.next());
        Console.WriteLine("prime_number: {0}", prime.next());
        Console.WriteLine("prime_number: {0}", prime.next());
        Console.WriteLine("prime_number: {0}", prime.next());
        Console.WriteLine("prime_number: {0}", prime.next());
        Console.WriteLine("prime_number: {0}\n", prime.next());
        Console.WriteLine("rand_number: {0}", random.next());
        Console.WriteLine("rand_number: {0}", random.next());
        Console.WriteLine("rand_number: {0}\n", random.next());
        Console.WriteLine("rand_word: {0}", rand_word.next());
        Console.WriteLine("rand_word: {0}", rand_word.next());
        Console.WriteLine("rand_word: {0}", rand_word.next());
        Console.WriteLine("rand_word: {0}\n", rand_word.next());
    
	}
}