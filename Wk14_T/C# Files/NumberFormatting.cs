using System;

public class NumberFormatting {
	public static void Main() {

	// (C)urrency formatting		
	Console.WriteLine("{0:C}", 2.567);		// default 2 decimals (Rounds)
	Console.WriteLine("{0:C1}", 2.567);		// 1 decimal 
	Console.WriteLine("{0:C0}", 2.567);		// 0 decimals
	Console.WriteLine("{0:C0}", 2367.567);	// 0 decimals, *with commas*

	// (F)ixed-point formatting		
	Console.WriteLine("\n{0:F0}", 2.567);	// 0 decimals (Rounds)
	Console.WriteLine("{0:F3}", 2.567);		// 3 decimals
	Console.WriteLine("{0:F}", 2567);		// default 2 decimals, *no comma*

	// (N)umber formatting		
	Console.WriteLine("\n{0:N0}", 2.567);	// 0 decimals (Rounds)
	Console.WriteLine("{0:N1}", 1234567.89);// 1 decimal, *with commas*
	Console.WriteLine("{0:N}", 2567);		// default 2 decimals, *with commas*
	
	// Another formatting option - convert to a string
	double number = 2342.567;
	string s1 = number.ToString("F1");
	string s2 = number.ToString("N5");
	string s3 = number.ToString("C");

	Console.WriteLine("\nAnother formatting option...\nConvert to a string (All Round)...");	
	Console.WriteLine("\nOriginal Number: " + number);
	Console.WriteLine("Fixed-1 Decimal-no comma: " + s1);
	Console.WriteLine("Number-5 Decimals-comma: " + s2);
	Console.WriteLine("Currency-default 2-comma: " + s3);
	
	} // end Main
} // end class