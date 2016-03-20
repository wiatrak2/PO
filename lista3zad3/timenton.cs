using System;

namespace TimeNTonLib
{
    public sealed class TimeNTon
    {
        private static int N = 21;
        private static TimeNTon[] instance = new TimeNTon[N];
        public  static int instance_id;
        public int id;
        private static DateTime start = new DateTime(2016, 3, 19, 10, 15, 0);
		private static DateTime end = new DateTime(2016, 3, 19, 12, 0, 0);
        
        private TimeNTon(int instance_id)
        {
            this.id = instance_id;
        }
        
        public int return_id()
        {
            return this.id;
        }
        
        public static TimeNTon Instance ()
        {
            
            DateTime current_date = DateTime.Now;
            TimeNTon res;
            
            if (current_date >= start && current_date <= end)
            {
                if (instance_id < N)
                       instance[instance_id] = new TimeNTon(instance_id);
                        
                res = instance[instance_id % N];
            }
            else
            {
                if (instance[0] == null)
                     instance[0] = new TimeNTon(0);
                     
                res = instance[0];
            }
            
            instance_id ++;   
            return res;             
        }                
    }
}