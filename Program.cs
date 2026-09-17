	using System;

	class Program
	{
		static void Main()
		{
			bool continueRunning = true;

			while (continueRunning)
			{
				ShowMenu();
				int option = ReadInteger("Select an option: ");
				Console.WriteLine();

				switch (option)
				{
					case 1:
						PositivePower();
						break;
					case 2:
						DoubleOrTriple();
						break;
					case 3:
						RootOrSquare();
						break;
					case 4:
						CirclePerimeter();
						break;
					case 5:
						MidweekDay();
						break;
					case 6:
						TaxCalculator();
						break;
					case 7:
						RemainderFinder();
						break;
					case 8:
						SumOfEvens();
						break;
					case 9:
						FractionDifference();
						break;
					case 10:
						StringLength();
						break;
					case 11:
						AverageOfFour();
						break;
					case 12:
						SmallestOfFive();
						break;
					case 13:
						VowelCounter();
						break;
					case 14:
						FactorialFinder();
						break;
					case 15:
						InRangeValidator();
						break;
					case 0:
						continueRunning = false;
						Console.WriteLine("Program finished.");
						break;
					default:
						Console.WriteLine("Invalid option.");
						Pause();
						break;
				}
			}
		}

		static void ShowMenu()
		{
			Console.WriteLine("====================================");
			Console.WriteLine("  Seleccione el ejercicio a resolver.");
			Console.WriteLine("====================================");
			Console.WriteLine("1. Positive Power");
			Console.WriteLine("2. Double or Triple");
			Console.WriteLine("3. Root or Square");
			Console.WriteLine("4. Circle Perimeter");
			Console.WriteLine("5. Midweek Day");
			Console.WriteLine("6. Tax Calculator");
			Console.WriteLine("7. Remainder Finder");
			Console.WriteLine("8. Sum of Evens");
			Console.WriteLine("9. Fraction Difference");
			Console.WriteLine("10. String Length");
			Console.WriteLine("11. Average of Four");
			Console.WriteLine("12. Smallest of Five");
			Console.WriteLine("13. Vowel Counter");
			Console.WriteLine("14. Factorial Finder");
			Console.WriteLine("15. InRange Validator");
			Console.WriteLine("0. Exit");
			Console.WriteLine();
		}

		static void PositivePower()
		{
			double number = ReadDouble("Enter a number: ");

			if (number < 0)
			{
				Console.WriteLine("Negative number.");
			}
			else
			{
				Console.WriteLine($"Result: {number * number}");
			}

			Pause();
		}

		static void DoubleOrTriple()
		{
			double firstNumber = ReadDouble("Enter the first number: ");
			double secondNumber = ReadDouble("Enter the second number: ");
			double result = firstNumber > secondNumber
				? firstNumber * 2
				: secondNumber * 3;

			Console.WriteLine($"Result: {result}");
			Pause();
		}

		static void RootOrSquare()
		{
			double number = ReadDouble("Enter a number: ");
			double result = number >= 0 ? Math.Sqrt(number) : number * number;

			Console.WriteLine($"Result: {result}");
			Pause();
		}

		static void CirclePerimeter()
		{
			double radius = ReadDouble("Enter the radius: ");
			double perimeter = 2 * Math.PI * radius;

			Console.WriteLine($"Perimeter: {perimeter:F2}");
			Pause();
		}

		static void MidweekDay()
		{
			int number = ReadInteger("Enter a number from 1 to 5: ");
			string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

			if (number >= 1 && number <= 5)
			{
				Console.WriteLine($"Day: {days[number - 1]}");
			}
			else
			{
				Console.WriteLine("Number outside the workday range.");
			}

			Pause();
		}

		static void TaxCalculator()
		{
			double salary = ReadDouble("Enter the annual salary: ");

			if (salary > 12000)
			{
				double tax = (salary - 12000) * 0.15;
				Console.WriteLine($"Tax: {tax:F2}");
			}
			else
			{
				Console.WriteLine("No taxes are owed.");
			}

			Pause();
		}

		static void RemainderFinder()
		{
			int firstNumber = ReadInteger("Enter the first integer: ");
			int secondNumber;

			do
			{
				secondNumber = ReadInteger("Enter the second integer (not 0): ");
				if (secondNumber == 0)
				{
					Console.WriteLine("The second number cannot be 0.");
				}
			} while (secondNumber == 0);

			Console.WriteLine($"Remainder: {firstNumber % secondNumber}");
			Pause();
		}

		static void SumOfEvens()
		{
			int sum = 0;

			for (int number = 1; number <= 50; number++)
			{
				if (number % 2 == 0)
				{
					sum += number;
				}
			}

			Console.WriteLine($"Sum of evens: {sum}");
			Pause();
		}

		static void FractionDifference()
		{
			int numerator1 = ReadInteger("First fraction, numerator: ");
			int denominator1 = ReadDenominator("First fraction, denominator: ");
			int numerator2 = ReadInteger("Second fraction, numerator: ");
			int denominator2 = ReadDenominator("Second fraction, denominator: ");

			int numerator = numerator1 * denominator2 - numerator2 * denominator1;
			int denominator = denominator1 * denominator2;

			if (numerator == 0)
			{
				Console.WriteLine("Result: 0");
			}
			else
			{
				int divisor = GreatestCommonDivisor(Math.Abs(numerator), Math.Abs(denominator));
				numerator /= divisor;
				denominator /= divisor;

				if (denominator < 0)
				{
					numerator = -numerator;
					denominator = -denominator;
				}

				Console.WriteLine($"Difference: {numerator}/{denominator}");
			}

			Pause();
		}

		static void StringLength()
		{
			Console.Write("Enter a word or short text: ");
			string text = Console.ReadLine() ?? string.Empty;

			Console.WriteLine($"Number of characters: {text.Length}");
			Pause();
		}

		static void AverageOfFour()
		{
			double sum = 0;

			for (int counter = 1; counter <= 4; counter++)
			{
				sum += ReadDouble($"Enter number {counter}: ");
			}

			Console.WriteLine($"Average: {sum / 4}");
			Pause();
		}

		static void SmallestOfFive()
		{
			double smallest = ReadDouble("Enter number 1: ");

			for (int counter = 2; counter <= 5; counter++)
			{
				double number = ReadDouble($"Enter number {counter}: ");
				if (number < smallest)
				{
					smallest = number;
				}
			}

			Console.WriteLine($"Smallest number: {smallest}");
			Pause();
		}

		static void VowelCounter()
		{
			Console.Write("Enter a word: ");
			string word = Console.ReadLine() ?? string.Empty;
			int vowelCount = 0;

			foreach (char character in word)
			{
				if ("aeiouAEIOU".Contains(character))
				{
					vowelCount++;
				}
			}

			Console.WriteLine($"Number of vowels: {vowelCount}");
			Pause();
		}

		static void FactorialFinder()
		{
			int number = ReadInteger("Enter a non-negative integer: ");

			if (number < 0)
			{
				Console.WriteLine("Factorial is not defined for negative numbers.");
				Pause();
				return;
			}

			try
			{
				long factorial = 1;
				for (int counter = 2; counter <= number; counter++)
				{
					factorial = checked(factorial * counter);
				}

				Console.WriteLine($"Factorial: {factorial}");
			}
			catch (OverflowException)
			{
				Console.WriteLine("The result is too large to calculate.");
			}

			Pause();
		}

		static void InRangeValidator()
		{
			double number = ReadDouble("Enter a number: ");

			if (number >= 10 && number <= 20)
			{
				Console.WriteLine("The number is in range.");
			}
			else
			{
				Console.WriteLine("The number is out of range.");
			}

			Pause();
		}

		static int ReadInteger(string message)
		{
			int number;
			Console.Write(message);

			while (!int.TryParse(Console.ReadLine(), out number))
			{
				Console.Write("Invalid data. Enter an integer: ");
			}

			return number;
		}

		static double ReadDouble(string message)
		{
			double number;
			Console.Write(message);

			while (!double.TryParse(Console.ReadLine(), out number))
			{
				Console.Write("Invalid data. Enter a number: ");
			}

			return number;
		}

		static int ReadDenominator(string message)
		{
			int denominator;

			do
			{
				denominator = ReadInteger(message);
				if (denominator == 0)
				{
					Console.WriteLine("The denominator cannot be 0.");
				}
			} while (denominator == 0);

			return denominator;
		}

		static int GreatestCommonDivisor(int firstNumber, int secondNumber)
		{
			while (secondNumber != 0)
			{
				int remainder = firstNumber % secondNumber;
				firstNumber = secondNumber;
				secondNumber = remainder;
			}

			return firstNumber;
		}

		static void Pause()
		{
			Console.WriteLine();
			Console.Write("Press a key to return to the menu...");

			if (Console.IsInputRedirected)
			{
				Console.ReadLine();
			}
			else
			{
				Console.ReadKey(true);
			}

			Console.WriteLine();
			Console.WriteLine();
		}
	}
