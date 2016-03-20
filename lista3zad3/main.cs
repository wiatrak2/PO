
using System;
using TimeNTonLib;

class Program
{
    static void Main(string[] args)
    {
        TimeNTonLib.TimeNTon i1 = TimeNTonLib.TimeNTon.Instance();
		Console.WriteLine(i1.return_id());
		
		TimeNTonLib.TimeNTon i2 = TimeNTonLib.TimeNTon.Instance();
		Console.WriteLine(i2.return_id());
		
		TimeNTonLib.TimeNTon i3 = TimeNTonLib.TimeNTon.Instance();
		Console.WriteLine(i3.return_id());
		
		TimeNTonLib.TimeNTon i4 = TimeNTonLib.TimeNTon.Instance();
		Console.WriteLine(i4.return_id());
    }
}