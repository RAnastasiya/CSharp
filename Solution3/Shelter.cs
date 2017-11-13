using System;

namespace Solution3
{
	public class Shelter{
		private int countDog;
		private int countCat;
		public int CountDog{
			get{
				return Convert.ToInt32(countDog);
			}
			set{
				if ((value > 0)){
					countDog = value;
				}
			}
		}
		public int CountCat{
			get{
				return Convert.ToInt32(countCat);
			}
			set{
				if ((value > 0)){
					countCat = value;
				}
			}
		}

		public Shelter(){
			Console.WriteLine ("Enter the number of dog admitted to the shelter");
			countDog = EnterAnim ("Dog");
			Console.WriteLine ("Enter the number of cat admitted to the shelter");
			countCat = EnterAnim ("Cat");
		}
		private static int EnterAnim(string an){
			int count;
			while(true){
				try {
					count = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine ("Count {0} is {1}", an, count);
					break;
				} catch (Exception) {
					Console.WriteLine ("You can enter only an integer");
				}
			}
			return count;
		}
	}
}