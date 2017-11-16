using System;

namespace Solution3
{
	class Cat: Body{			

		public string Type { get; set;}    
		public int Age { get; set;}    
		public float Mood { get; set;} 
		public override void Print(){
			Console.WriteLine ("id: " + Id + 
			                   "  Date: " + Date + 
			                   "  Type: " + Type + 
			                   "  Age: " + Age + 
			                   "  Mood: " + Mood);
		}
	}
}