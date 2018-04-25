public class Person {

	private String name;
	private int age;
	private String ssNumber;

	//no argument constructor
	public Person() {
		name = "uninitialized";
		age = -1;
		ssNumber = "uninitialized";
	}

	//3 argument constructor - name, age, ss#
	public Person(String n, int a, String ss) {
		name = n;
		age = a;
		ssNumber = ss;
	}

	//methods
	public void display() {
		System.out.println("\nName: " + name);
		System.out.println("Age: " + age);
		System.out.println("SS #: " + ssNumber + "\n");
	} // end display()

	public String toString() {
		return ("\nName: " + name
		+ "\nAge: " + age
		+ "\nSS #: " + ssNumber + "\n");
	} // end toString()

	// add method to parse name so it stored as: "Last, First"
	public void parseName() {
		String [ ] temp = name.split(" ");
		name = temp[1] + ", " + temp[0];
	} // end parseName


	// add method to store last four digits of SS number
	public void parseSS() {
		String [ ] temp = ssNumber.split("-");
		System.out.println("Last four digits of your SS#: " + temp[2]);
	} // end parseSS

} // end class Person