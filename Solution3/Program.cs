using System;
using System.Collections.Generic;

namespace Solution3
{
	class MainClass
	{
		public static void Main (string[] args)
		{			
			Shelter shelter = new Shelter ();
			Dog[] dog = new Dog[shelter.CountDog];
			Cat[] cat = new Cat[shelter.CountCat];
			int c = shelter.CountDog + shelter.CountCat;
			Console.WriteLine ("dog + cat = " + c);
			for (int i = 0; i < c; i++) {
				Console.WriteLine ("dog or cat?");
				string readLine = Console.ReadLine();
				if (readLine.ToLower() == "dog"){
					dog [i] = new Dog ();
					dog [i].count = shelter.CountDog;
					dog [i].Id = i;

					ConsoleKeyInfo keypress;
					Console.WriteLine ("Enter date ");
					dog [i].Date = Convert.ToString(Console.ReadLine ());
					keypress = Console.ReadKey();
					if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0){
						for (int j = 0; j <= i; j++) {
							dog [j].Print ();
						}
					}
					Console.WriteLine ("Enter gender: 'man' or 'woman'");
					while (true) {
						readLine = (Console.ReadLine ()).ToLower ();
						if ((readLine == "man" || readLine == "woman")) {
							dog [i].Sex = readLine;
							break;
						} else {
							Console.WriteLine ("Enter valide : 'man' or 'woman'");
							continue;
						}
					}
					keypress = Console.ReadKey();
					if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0){
						for (int j = 0; j <= i; j++) {
							dog [j].Print ();
						}
					}
					Console.WriteLine ("Do you have documents confirming this identity? 'y' or 'n'");
					while (true) {
						readLine = (Console.ReadLine ()).ToLower ();
						if ( readLine == "y") {
							dog [i].Identified = true;
						} else if (readLine == "n") {
							dog [i].Identified = false;
						} else {
							Console.WriteLine ("Enter valide : y or n");
							continue;
						}
						break;
					}
					keypress = Console.ReadKey();
					if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0){
						for (int j = 0; j <= i; j++) {
							dog [j].Print ();
						}
					}
					Console.WriteLine ("Enter age ");
					while(true){
						try {
							dog[i].Age = Convert.ToInt32(Console.ReadLine());
							break;
						} catch (Exception) {
							Console.WriteLine ("You can enter only an integer");
						}
					}		
					keypress = Console.ReadKey();
					if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0){
						for (int j = 0; j <= i; j++) {
							dog [j].Print ();
						}
					}
					continue;
				}else if(readLine.ToLower() == "cat"){
					cat [i] = new Cat ();
					Console.WriteLine ("cat   cat   cat   cat");
					continue;
				}else{
					Console.WriteLine ("Enter valide gender: dog or cat");
					continue;
				}
			}
		}
	}
}

