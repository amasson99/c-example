using System;

public class Person {

	private string name;
	private int age;
	private string ssNumber;

	//no argument constructor
	public Person() {
		name = "unitialized";
		age = -1;
		ssNumber = "unitialized";
	}

	//3 argument constructor - name, age, ss#
	public Person(string n, int a, string ss) {
		name = n;
		age = a;
		ssNumber = ss;
	}

	//methods
	public void display() {
		Console.WriteLine("\nName: " + name);
		Console.WriteLine("Age: " + age);
		Console.WriteLine("SS #: " + ssNumber + "\n");
	} // end display()

	public override string ToString() {
		return ("\nName: " + name
		+ "\nAge: " + age
		+ "\nSS #: " + ssNumber + "\n");
	} // end toString()

	// add method to parse name so it stored as: "Last, First"
	public void parseName() {
		string [ ] temp = name.Split(' ');
		name = temp[1] + ", " + temp[0];
	} // end parseName


	// add method to store last four digits of SS number
	public void parseSS() {
		String [ ] temp = ssNumber.Split('-');
		Console.WriteLine("Last four digits of your SS#: " + temp[2]);
	} // end parseSS

} // end class Person