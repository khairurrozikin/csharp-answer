using System;

namespace EvenOdd
{
    class Program
    {
        static bool isEven(int n)
        { 
        bool isEven = true;  
        for (int i = 1; i <= n; i++)  
            isEven = !isEven;

        return isEven; 
    }
    static void Main(string[] args)
    {
            // Create new method with ability to detect odd or even number.
            // Example:
            // IsOdd(4) // false
            // IsEven(8) // true
            int n = 8; 
            if(isEven(n))
            Console.Write("Even"); 
            else
            Console.Write("Odd"); 

        }
    }
}
