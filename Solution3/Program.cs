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
			for (int i = 0; i < (shelter.CountDog + shelter.CountCat); i++) {
				string readLine = shelter.Choice ();
				if (readLine.ToLower() == "dog"){
					dog [i] = new Dog ();
					dog [i].Id = i;

					ConsoleKeyInfo keypress;
					Console.WriteLine ("Enter date ");
					dog [i].Date = Convert.ToString(Console.ReadLine ());
					keypress = Console.ReadKey();
					if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0){
						for (int j = 0; j <= i; j++) {
							try{
								dog [j].Print ();
							} catch (Exception) {
								continue;
							}
						}
					}
					Console.WriteLine ("Enter gender: male or female");
					while (true) {
						readLine = (Console.ReadLine ()).ToLower ();
						if ((readLine == "male" || readLine == "female")) {
							dog [i].Sex = readLine;
							break;
						} else {
							Console.WriteLine ("Enter valide : male or female");
							continue;
						}
					}
					keypress = Console.ReadKey();
					if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0){
						for (int j = 0; j <= i; j++) {
							try{
								dog [j].Print ();
							} catch (Exception) {
								continue;
							}
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
							try{
								dog [j].Print ();
							} catch (Exception) {
								continue;
							}
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
							try{
								dog [j].Print ();
							} catch (Exception) {
								continue;
							}
						}
					}
					continue;
				}else if(readLine.ToLower() == "cat"){
					cat [i] = new Cat ();
					Console.WriteLine ("Caaaaaaaaaaat");
					continue;
				}else{
					Console.WriteLine ("Enter valide gender: dog or cat");
					continue;
				}
			}
		}
	}
}

