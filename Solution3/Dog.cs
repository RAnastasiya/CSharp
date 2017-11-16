using System;

namespace Solution3
{
	class Dog: Body{
		public string Sex { get; set;}
		public void ReceiveSex(){
			Console.WriteLine ("Enter gender: 'male' or 'female'");
			string readReceive;
			while (true) {
				readReceive = Console.ReadLine ();
				if ((readReceive == "male" || readReceive == "female")) {
					this.Sex = readReceive;
					break;
				} else {
					Console.WriteLine ("Enter valide: 'male' or 'female'");
					continue;
				}
			}
		}
		public bool Identified { get; set;}     
		public void ReceiveIdentified(){
			Console.WriteLine ("Do you have documents confirming this identity? 'y' or 'n'");
			string readReceive;
			while (true) {
				readReceive = (Console.ReadLine ()).ToLower ();
				if ( readReceive == "y") {
					Identified = true;
				} else if (readReceive == "n") {
					Identified = false;
				} else {
					Console.WriteLine ("Enter valide : y or n");
					continue;
				}
				break;
			}
		}
		public int Age { get; set;}
		public void ReceiveAge(){
			Console.WriteLine ("Enter age ");
			while(true){
				try {
					Age = Convert.ToInt32(Console.ReadLine());
					break;
				} catch (Exception) {
					Console.WriteLine ("You can enter only an integer");
				}
			}
		}
		public override void Print(){
			Console.WriteLine ("id: " + Id + 
			                   "  Date: " + Date + 
			                   "  Sex: " + Sex + 
			                   "  Identified: " + Identified + 
			                   "  Age: " + Age);
		}
	}
}