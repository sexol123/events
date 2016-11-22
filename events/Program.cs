/*
 * Created by SharpDevelop.
 * User: sexol
 * Date: 11/22/2016
 * Time: 19:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace events
{
	

   
 
	
	public class Program
	{
		
		public delegate void MyDelegate();
	    public static event MyDelegate MyEvent;
		public static MyDelegate itemdel;
		public static void Main(string[] args)
		{
			
			
			Handler_II hh = new Handler_II();
			itemdel = hh.Message;
			itemdel += hh.Message;
			itemdel += Handler_I.Message;
			
			MyEvent += hh.Message;
			MyEvent += Handler_I.Message;
			ClassCounter.Count();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static class ClassCounter  //Это класс - в котором производится счет.
		{
		    public static int cc;
       static public void Count()
        {
            for (int i = 0; i < 10; i++)
            {
                    cc = i;
            	Console.WriteLine("  "+i);
            	if (MyEvent != null)
            		if (i == 7)
            			 MyEvent();
            	if (itemdel != null)
            	    if (i == 9)
                         itemdel();
            	        Console.WriteLine("\n\n\n");
                        itemdel();
            }
        }
    }
        class Handler_II
        {
            public void Message()
            {
                Console.WriteLine($"Точно, уже {ClassCounter.cc}!");
            }
        }
        public static class Handler_I //Это класс, реагирующий на событие (счет равен 71) записью строки в консоли.
    {
        public static void Message()
        {
            
            Console.WriteLine($"Пора действовать, ведь уже {ClassCounter.cc}!"); 
        }                                                        
    }
	}
}