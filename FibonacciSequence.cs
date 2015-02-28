/* Author: Mohammad Hyderkhan
   Date: 25/02/2015
   Framework: .Net v4.5
   Compiler: .Net 4.5
   Project Type: Console application
   Language: C#
   Description: A c# console application that uses the fibonacci sequence to display numeric terms which are less than 4000000.
   		A grand total of all even numbers within the sequence is calcuted and displayed.
*/
using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		//Initialise starting point of sequence
		double slotOne = 1;
		
		//Initialise second point of sequence
		double slotTwo = 1;
		
		//Initialise the point in which the sequence will end
		double maxValue = 4000000;
		
		//Initialise variable that will hold the sum of computated even numbers in sequence
		double evenTotal = 0;
		
		List<double> fibonacciList = new List<double>();
		
		List<double> fibEvenList = new List<double>();
		
		for (double i = 0; slotTwo < maxValue; i++)
		{
			//A local variable to store the value thats currently being iterated
			double currentNumber = slotOne;
			
			//Assign the highest number in the sequence to the first slot
			slotOne = slotTwo;
			
			//Assign the sum of the previous number and the highest number to the second slot
			slotTwo = currentNumber + slotTwo;
			
			//Append new computated number to the fibonnaci list
			fibonacciList.Add(slotOne);
			
			//Check if the computated value is an even number
			if (slotTwo % 2 == 0)
			{
				//Append even number to the even number list
				fibEvenList.Add(slotTwo);
				
				//Add the computated number with the sum of all even numbers in the sequence
				evenTotal = evenTotal + slotTwo;
			}
		}

		//Convert both lists into readable format using string concatenation
		string concatFibonnaciList = string.Join(", ", fibonacciList);
		
		string concatFibEven = string.Join(" + ", fibEvenList);
		
		//Display the computated fibonnaci sequence to the console
		Console.WriteLine("The terms found in the Fibonnaci Sequence are as follows: ");
		
		Console.WriteLine(concatFibonnaciList);
		
		Console.WriteLine();
		
		//Display the sum of all even numbers in the sequence to the console
		Console.WriteLine("The sum of even-valued terms found in this sequence: ");
		
		Console.WriteLine(concatFibEven + " = " + evenTotal);
	}
}
