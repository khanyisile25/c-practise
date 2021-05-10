
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace c_sharp_practise
{
	

	namespace practise
	{
		class Program
		{
			static void main(string[] args)
			{
				int val1 = 11000;
				int val2 = 35600;
				long sum;

				sum = val1 + val2;

				Console.WriteLine("Sum= " + sum);

				Console.ReadLine();
			}
		}
	}

	// C# program to illustrate
	// object initializer syntax


	class faith
	{

		public string author_name
		{
			get;
			set;
		}
		public int author_id
		{
			get;
			set;
		}
		public int total_article
		{
			get;
			set;
		}
	}

	class GFG
	{

		// Main method
		static public void main()
		{

			// Initialize fields using
			// an object initializer
			faith obj = new faith()
			{
				author_name = "khanyisile",
				author_id = 102,
				total_article = 178
			};

			Console.WriteLine("Author Name: {0}", obj.author_name);

			Console.WriteLine("Author Id: {0}", obj.author_id);

			Console.WriteLine("Total no of articles: {0}",
									obj.total_article);
		}
	}

	// C# program to illustrate the
	// Lambda Expression



	namespace Lambda_Exressions
	{
		class Program
		{
			static void main(string[] args)
			{
				// List to store numbers
				List<int> numbers = new List<int>() {36, 71, 12,
							15, 29, 18, 27, 17, 9, 34};

				// foreach loop to dislay the list
				Console.Write("The list : ");
				foreach (var value in numbers)
				{
					Console.Write("{0} ", value);
				}
				Console.WriteLine();

				// Using lambda expression
				// to calculate square of
				// each value in the list
				var square = numbers.Select(x => x * x);

				// foreach loop to display squares
				Console.Write("Squares : ");
				foreach (var value in square)
				{
					Console.Write("{0} ", value);
				}
				Console.WriteLine();

				// Using Lambda exression to
				// find all numbers in the list
				// divisible by 3
				List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);

				// foreach loop to display divBy3
				Console.Write("Numbers Divisible by 3 : ");
				foreach (var value in divBy3)
				{
					Console.Write("{0} ", value);
				}
				Console.WriteLine();
			}
		}
	}
}

		
	
