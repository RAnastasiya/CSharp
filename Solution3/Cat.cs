using System;
using System.Globalization;

namespace Solution3
{
	class Cat: Body{			

		public string Type { get; set;}  
		public void ReceiveType(){
			Console.WriteLine ("Enter type: e.g. Siamese");
			string readReceive;
			readReceive = Console.ReadLine ();
			this.Type = readReceive;
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
		public float Mood { get; set;} 
		public void ReceiveMood(){
			Console.WriteLine ("Enter mood: e.g. 3.4");
			while (true) {
				float number;
				string value;
				NumberStyles style;
				CultureInfo culture;

				value = Console.ReadLine ();
				style = NumberStyles.AllowDecimalPoint;
				culture = CultureInfo.InvariantCulture;
				if (float.TryParse (value, style, culture, out number)){
					Mood = number;
					Console.WriteLine ("Converted '{0}' to {1}.", value, number);
					break;
				}else{
					Console.WriteLine ("You can enter only an float");
					Console.WriteLine("Unable to convert '{0}'.", value);
				}
			}
		}
		public override void Print(){
			Console.WriteLine ("id: " + Id + 
			                   "  Date: " + Date + 
			                   "  Type: " + Type + 
			                   "  Age: " + Age + 
			                   "  Mood: " + Mood);
		}
	}
}