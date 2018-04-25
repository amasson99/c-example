import java.util.*;

public class PersonApp {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);

		//create person Bob Smith, age 20, 515-00-9999 (Hardcode)
		Person pers1 = new Person("Bob Smith", 20, "515-00-9999");
		
		//create person ... read in info vs. hardcoding
		System.out.print("Enter name: ");
		String name = s.nextLine();
		System.out.print("Enter age: ");
		int age = Integer.parseInt(s.nextLine());
		System.out.print("Enter Social Security number (###-##-####): ");
		String ss = s.nextLine();
		Person pers2 = new Person(name, age, ss);
		
		pers1.parseName();
		pers2.parseName();
		
		//display pers1 using display method
		pers1.display();
		pers1.parseSS();

		//display pers2 using toString
		System.out.println(pers2);
		pers2.parseSS();
	}
}