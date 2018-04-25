using System;

public class Example1 {
  public static void Main() {

    string s = "C# Example";	
    string name;
    int num;
    double dNum;
    bool flag = true;

// arithmetic operators are the same (+,-,*,/)
// Conditionals / Loops are the same
// Comments are the same
 
// Display hard-coded string
    Console.WriteLine("CIS 200: " + s);

// get a String from the user, say hello
    Console.Write("What is your name? ");
    name = Console.ReadLine();
    Console.WriteLine("Hello, " + name);
	
// get an int number from the user, increase by one
    Console.Write("Enter an int number: ");
    num = Convert.ToInt32(Console.ReadLine());
    num++;

// get a double number from the user
    Console.Write("Enter a double number: ");
    dNum = Convert.ToDouble(Console.ReadLine());

// assigns true or false to flag (just for an example)
    flag = (num > dNum);

// display the one that is bigger
    if (flag)
      Console.WriteLine("integer plus one is greater");
    else
      Console.WriteLine(dNum + " (double) is greater");

// convert string to char (Character Input)
    Console.Write ("Do you wish to continue? (y/n): ");
    string response = Console.ReadLine();

// Line below works but exception thrown at runtime if string is not EXACTLY one char
   // char ch = Convert.ToChar(response);
      
// Better - strings in C# can be referenced like a char array 
   char ch = response[0];
      
   if (ch == 'y')
	Console.WriteLine ("Yes");
   else
	Console.WriteLine ("No");

// convert string to a character array
    String lang = "Java";  
	char [ ] cArray = lang.ToCharArray();
    Console.WriteLine("string = " + lang);
    Console.WriteLine("cArray = " + cArray);
    Console.WriteLine("Char 3 in string: " + lang[2]);
    Console.WriteLine("Char 3 in cArray: " + cArray[2]);

// Halting the console window from closing  
	Console.Write("\n\nPress <enter> to continue...\n");
	Console.ReadLine();

	// Console.Write("\n\nPress <any key> to end...");
	// Console.ReadKey();


//-------------------------------------------------------------

// Numeric Arrays - 1D same as Java
	int[] nums = new int[4];
	int size = nums.Length;  // capital 'L'

	// Display Contents - Array auto-initialized?
	Console.WriteLine("Contents of the numeric array...");
    //for (int i =0; i < size; i++)
    //	Console.WriteLine(nums[i]);

	foreach (int i in nums)
    	Console.WriteLine(i);
	
// Array of strings  
	string [ ] str = new string[4];
	size = str.Length;

	// Display Contents - Array auto-initialized?
    Console.WriteLine("Contents of the string array...");
	for (int i =0; i < size; i++)
    	Console.WriteLine((i+1) + ": " + str[i]);

// 2D Arrays
    int[,] grid = new int[3,4];
    grid[0,2] = 4;	// Row 1, Col 3
    grid[2,3] = 5;	// Row 3, Col 4

	// METHOD (not data property) GetLength()
	int numRows = grid.GetLength(0);
	int numCols = grid.GetLength(1);

    Console.WriteLine("Contents of the 2D array...");
	for (int row = 0; row < numRows; row++) {
		for (int col = 0; col < numCols; col++)
			Console.Write (grid[row,col] + " "); // inner for
	Console.WriteLine("");
	} // end outer for

  } // end main
} // end class