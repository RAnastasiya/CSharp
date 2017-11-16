using System;
using System.Collections.Generic;

/* TASK
 * 1. Створити базовий абстрактний клас. Мінімум 2 властивості
 * 2. Створити два дочірніх класи. Мінімум 3 властивості і всі різних типів
 * 3. Створити масив (кількість єлементів вказує користувач)
 * 4. Дати користувачеві заповнити масив. Користувач має сам обрати який саме клас (з двох дочірніх) він зараз хоче створити. 
 * 5. Користувач у будь-який момент заповнення масива може переглянути уже заповнені елементи
 */

namespace Solution3{
	class MainClas{
		public static void Main (string[] args){			
			Shelter shelter = new Shelter ();
			Body[] body = new Body[shelter.CountDog + shelter.CountCat];
			for (int i = 0; i < body.Length; i++) {
				string readLine = shelter.Choice ();
				if (readLine.ToLower() == "dog"){
					Dog dog = new Dog ();
					Console.Clear ();
					body[i] = dog;
					dog.Id = i;
					dog.ReceiveDate();
					PrintArray (i, body);
					dog.ReceiveSex();
					PrintArray (i, body);
					dog.ReceiveIdentified ();
					PrintArray (i, body);
					dog.ReceiveAge ();
					PrintArray (i, body);
					continue;
				}else if(readLine == "cat"){
					Cat cat = new Cat ();
					body[i] = cat;
					cat.Id = i;
					PrintArray (i, body);
					Console.WriteLine ("Caaaaaaaaaaat");
					continue;
				}else if(readLine == "not"){
					Console.WriteLine ("Recording is complete");
					break;
				}else{
					Console.WriteLine ("You entered an incorrect value");
					i--;
					continue;
				}
			}
		}
		public static void PrintArray (int i, Body[] body){
			ConsoleKeyInfo keypress;
			keypress = Console.ReadKey();
			if ((ConsoleModifiers.Shift & keypress.Modifiers) != 0){
				for (int j = 0; j <= i; j++) {
					try{
						Console.ForegroundColor = ConsoleColor.Green;
						body[j].Print ();
						Console.ReadKey();
						Console.ResetColor ();
					} catch (Exception) {
						continue;
					}
				}
			}
			Console.Clear();
		}

	}
}

