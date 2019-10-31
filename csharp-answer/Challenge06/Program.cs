using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method called Grade()
            // That method should accept an integer with some criteria
            // 1) If the input more than 90 the output will be "A"
            // 2) If the input within range 80 to 89 the output will be "B"
            // 3) If the input within range 70 to 79 the output will be "C"
            // 4) If the input within range 60 to 69 the output will be "D"
            // 5) If the input below 59 the output will be "E"
            // Store marks of all the subjects 
            int []marks = { 25, 65, 46, 98, 78, 65 };  
            int max_marks = marks.Length * 100;  
            int total = 0;  
            char grade = 'F';
            for (int i = 0; i < marks.Length; i++)
            {
                total += marks[i];
                }
                double percentage = ((double)(total) / max_marks) * 100;
                
                if (percentage >= 90)
                {
                    grade = 'A';
                    }else
                    {
                        if (percentage >= 80 && percentage <= 89)
                        {
                            grade = 'B';
                            }else
                            {
                                if (percentage >= 60 && percentage <= 79)
                                {
                                    grade = 'C';
                                    }else
                                    {
                                        if (percentage >= 33 && percentage <= 59)
                                        {
                                            grade = 'D';
                                            }else
                                            {
                                                grade = 'F';
                                                }
                                            }
                                        }
                                    }
                                Console.WriteLine(grade);
                            }
                        }
                    }