using System;
using System.Collections.Generic;

namespace Solution3
{
	class MainClass
	{
		public static void Main (string[] args)
		{			
			Shelter shelter = new Shelter ();
			Body[] body = new Body[shelter.CountDog + shelter.CountCat];
			for (int i = 0; i < (shelter.CountDog + shelter.CountCat); i++) {
				string readLine = shelter.Choice ();
				if (readLine.ToLower() == "dog"){
					Dog dog = new Dog ();
					body[i] = dog;
					dog.Id = i;

					ConsoleKeyInfo keypress;
					Console.WriteLine ("Enter date ");
					dog.Date = Convert.ToString(Console.ReadLine ());
					keypress = Console.ReadKey();
					if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0){
						for (int j = 0; j <= i; j++) {
							try{
								dog.Print ();
							} catch (Exception) {
								continue;
							}
						}
					}
					Console.WriteLine ("Enter gender: male or female");
					while (true) {
						readLine = (Console.ReadLine ()).ToLower ();
						if ((readLine == "male" || readLine == "female")) {
							dog.Sex = readLine;
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
								dog.Print ();
							} catch (Exception) {
								continue;
							}
						}
					}
					Console.WriteLine ("Do you have documents confirming this identity? 'y' or 'n'");
					while (true) {
						readLine = (Console.ReadLine ()).ToLower ();
						if ( readLine == "y") {
							dog.Identified = true;
						} else if (readLine == "n") {
							dog.Identified = false;
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
								dog.Print ();
							} catch (Exception) {
								continue;
							}
						}
					}
					Console.WriteLine ("Enter age ");
					while(true){
						try {
							dog.Age = Convert.ToInt32(Console.ReadLine());
							break;
						} catch (Exception) {
							Console.WriteLine ("You can enter only an integer");
						}
					}		
					keypress = Console.ReadKey();
					if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0){
						for (int j = 0; j <= i; j++) {
							try{
								dog.Print ();
							} catch (Exception) {
								continue;
							}
						}
					}
					continue;
				}else if(readLine == "cat"){
					Cat cat = new Cat ();
					body[i] = cat;
					cat.Id = i;
					Console.WriteLine ("Caaaaaaaaaaat");
					continue;
				}else if(readLine == "not"){
					Console.WriteLine ("Recording is complete");
					continue;
				}else{
					Console.WriteLine ("Enter valide gender: dog or cat");
					continue;
				}
			}
		}
	}
}

