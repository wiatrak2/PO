using System;
using System.Collections;
namespace PrimeLib
{
    public class Prime : IEnumerator
    {
        private int sqrt_max = (int)Math.Sqrt(int.MaxValue);
        private int current_val;
        public int next_prim(int current_val)
        {
          if (current_val < 2)
              return 2;
                
           for (int i = current_val + 1; i <= sqrt_max; i++)
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
       
       public Prime()
       {
           this.current_val = 1;
       }
       
       public bool MoveNext()
       {
           this.current_val = next_prim(current_val);
           return current_val != 0;
       }
       
       public void Reset()
       {
           this.current_val = 1;
       }
       
       public object Current
       {
           get
           {
               return this.current_val;
           }
       }
    }
    
    public class PrimeCollection : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			return new Prime();
		}
	}

}