using System;

namespace Solution3
{
	class Dog: Body{						
		public string Sex { get; set;}     
		public bool Identified { get; set;}     
		public int Age { get; set;}   
		public override void Print(){
			Console.WriteLine ("id: " + Id + 
			                   "  Date: " + Date + 
			                   "  Sex: " + Sex + 
			                   "  Identified: " + Identified + 
			                   "  Age: " + Age);
		}
	}
}