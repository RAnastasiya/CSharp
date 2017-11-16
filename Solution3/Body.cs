using System;

namespace Solution3
{
	abstract class Body{		
		public int count = 0;  
		public int Id{ get; set;}   
		public DateTime Date{ get; set;}  
		public abstract void Print ();
		public void ReceiveDate(){
			Console.WriteLine ("Enter date ");

			while(true){
				try {
					Date = Convert.ToDateTime(Console.ReadLine());
					break;
				} catch (Exception) {
					Console.WriteLine ("You can enter only date MM/dd/yyyy");
				}
			}
		}
	}
}