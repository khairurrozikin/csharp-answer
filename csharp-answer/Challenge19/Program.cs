﻿using System;

namespace Sorter
{
    class Program
    {
        static void sort(int []arr) 
	{ 
		int n = arr.Length; 
		for (int i = 0; i < n - 1; i++) 
		{ 
			int min_idx = i; 
			for (int j = i + 1; j < n; j++) 
				if (arr[j] < arr[min_idx]) 
					min_idx = j; 
			int temp = arr[min_idx]; 
			arr[min_idx] = arr[i]; 
			arr[i] = temp; 
		} 
	} 
	
	static void printArray(int []arr) 
	{ 
		int n = arr.Length; 
		for (int i=0; i<n; ++i) 
			Console.Write(arr[i]+" "); 
		Console.WriteLine(); 
	} 
	
	public static void Main() 
	{ 
		int[] arr = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54}; 
		sort(arr); 
		Console.WriteLine("Sorted array"); 
		printArray(arr); 
	} 

} 
}