using System;

public class PersonApp {
	public static void Main() {

		//create person Bob Smith, age 20, 515-00-9999 (Hardcode)
		Person pers1 = new Person("Bob Smith", 20, "515-00-9999");
		
		//create person ... read in info vs. hardcoding
		Console.Write("Enter name: ");
		string name = Console.ReadLine();
		Console.Write("Enter age: ");
		int age = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter Social Security number (###-##-####): ");
		string ss = Console.ReadLine();
		Person pers2 = new Person(name, age, ss);
		
		pers1.parseName();
		pers2.parseName();
		
		//display pers1 using display method
		pers1.display();
		pers1.parseSS();

		//display pers2 using toString
		Console.WriteLine(pers2);
		pers2.parseSS();

		Console.Write("\n\nPress <any key> to end...");
		Console.ReadKey();
	} // end Main
} // end class