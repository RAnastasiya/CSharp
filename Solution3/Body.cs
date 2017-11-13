using System;

namespace Solution3
{
	abstract class Body{		
		public int count = 0;  
		public int Id{ get; set;}   
		public string Date{ get; set;}  
		public abstract void Print ();
	}
}