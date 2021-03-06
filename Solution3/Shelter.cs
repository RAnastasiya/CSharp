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
			Console.WriteLine ("Enter free places for dogs");
			countDog = EnterAnim ("Dog");
			Console.Clear ();
			Console.WriteLine ("Enter free places for cats");
			countCat = EnterAnim ("Cat");
			Console.Clear ();
		}
		private static int EnterAnim(string an){
			int count;
			while(true){
				try {
					count = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine ("Number of free places for {0}s is {1}", an, count);
					break;
				} catch (Exception) {
					Console.WriteLine ("You can enter only an integer");
				}
			}
			return count;
		}
		public string Choice(){
			string readLine;
			if (countDog == 0) {
				readLine = AnswerToQuestion("cat");
				if (readLine == "yes")
					readLine = "dog";
			} else if (countCat == 0) {
				readLine = AnswerToQuestion("dog");
				if (readLine == "yes")
					readLine = "cat";
			} else {
				Console.WriteLine ("Enter the animal you want to record: dog or cat");
				readLine = Console.ReadLine ();
			}
			if (readLine == "dog")
				countDog -= 1;
			else if (readLine == "cat")
				countCat -= 1;
			Console.Clear ();
			return readLine;
		}
		private static string AnswerToQuestion(string an){
			string readLine;
			Console.WriteLine ("Only places left for {0}s.\nDo you want to add a {0} to the shelter: yes or not", an);
			string answer = Console.ReadLine ();
			if (answer == "yes") {
				readLine = an;
			} else {
				readLine = "not";
			}
			return readLine;
		}
	}
}