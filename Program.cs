using System;
using System.Collections.Generic;

namespace FindSumCombos
{
	class Program
	{
		static void Main(string[] args)
		{
			FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
			Console.WriteLine("Hello World!");
			Console.ReadLine();
		}

		public static void FindTwoSum(List<int> items, int target)
		{ 
			items.Sort();
			int i = 0;
			int j = items.Count - 1;
			while (i < j)
			{
				if (items[i] + items[j] == target)
				{
					Console.WriteLine("{" + items[i] + "," + items[j] + "}");
					i++;
					j--;
				}
				else if (items[i] + items[j] < target)
					i++;
				else if (items[i] + items[j] > target)
					j--;
			}
		}
	}
}
