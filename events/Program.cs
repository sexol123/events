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
	

    class Handler_II
    {
        public void Message()
        {
            Console.WriteLine("Точно, уже 7!");
        }    
    }
 
	
	public class Program
	{
		
		public delegate void MyDelegate();
		//public static event MyDelegate MyEvent;
		public static MyDelegate itemdel;
		public static void Main(string[] args)
		{
			
			
			Handler_II hh = new Handler_II();
			itemdel = hh.Message;
			//itemdel += hh.Message;
			itemdel += Handler_I.Message;
			
			//MyEvent += hh.Message;
			//MyEvent += Handler_I.Message;
			ClassCounter.Count();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static class ClassCounter  //Это класс - в котором производится счет.
    {
		
       static public void Count()
        {
            for (int i = 0; i < 10; i++)
            {
            	Console.WriteLine("  "+i);
            	if (itemdel/*MyEvent*/ != null)
            		if (i == 7)
            			//MyEvent();
            			itemdel();
            		
            }
        }
    }
	public static class Handler_I //Это класс, реагирующий на событие (счет равен 71) записью строки в консоли.
    {
        public static void Message()
        {
            
            Console.WriteLine("Пора действовать, ведь уже 7!"); 
        }                                                        
    }
	}
}