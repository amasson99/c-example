using System;

public class String_Methods {
  public static void Main() {

 // Strings and Substrings
	string s = "hello";

	Console.WriteLine("\ns: " + s);
    //comparing strings in C#
	// == is an 'overloaded operator'
	if (s == "hello")
		Console.WriteLine("String 's' equals 'hello'");
		
	// Length DATA PROPERTY (not a method call, like Java)
	Console.WriteLine("Length of s: " + s.Length);

	Console.WriteLine("Separate lines using foreach loop");
	foreach (char c in s)
		Console.WriteLine (c);
		
	char firstLetter = s[0];		// 'h'
	Console.WriteLine("First Letter: " + firstLetter);
	
	char last = s[s.Length-1];		// 'o'
	Console.WriteLine("Last letter: " + last);

	string s1 = s.Substring(2);		// 'llo'
	Console.WriteLine("s1: " + s1);

	string s2 = s.Substring(1,2);	// 'el'
	Console.WriteLine("s2: " + s2);
	
	string ssNumber = "111-22-1234";
	Console.WriteLine("\nLength of ssNumber: " + ssNumber.Length);

	string last4 = ssNumber.Substring(ssNumber.Length-4);	
	Console.WriteLine("Last 4 digits of SS#: " + last4);

	string first3 = ssNumber.Substring(0,3);	
	Console.WriteLine("First 3 digits of SS#: " + first3);
	
	//Console.Write("\n\nPress <any key> to end...");
	//Console.ReadKey();

  } // end main
} // end class