using System;

class Program
{
    static void Main()
    {
        string[] names = new string[3];
        string[] ids = new string[3];
        string[] programmes = new string[3];
        string[] levels = new string[3];

        int[,] scores = new int[3, 5];

        int choice;

        do
        {
            Console.WriteLine("===== STUDENT RESULTS PROCESSING SYSTEM =====");
            Console.WriteLine("1. Enter Student Results");
            Console.WriteLine("2. View Student Report");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"\nEnter details for Student {i + 1}");

                    Console.Write("Name: ");
                    names[i] = Console.ReadLine();

                    Console.Write("Student ID: ");
                    ids[i] = Console.ReadLine();

                    Console.Write("Programme: ");
                    programmes[i] = Console.ReadLine();

                    Console.Write("Level: ");
                    levels[i] = Console.ReadLine();

                    for (int j = 0; j < 5; j++)
                    {
                        int score;

                        do
                        {
                            Console.Write($"Enter score {j + 1}: ");
                            score = Convert.ToInt32(Console.ReadLine());

                            if (score < 0 || score > 100)
                            {
                                Console.WriteLine("Invalid score. Score must be between 0 and 100.");
                            }

                        } while (score < 0 || score > 100);

                        scores[i, j] = score;
                    }
                }
            }

            else if (choice == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    int total = 0;

                    Console.WriteLine("\n========================");
                    Console.WriteLine($"Name: {names[i]}");
                    Console.WriteLine($"ID: {ids[i]}");
                    Console.WriteLine($"Programme: {programmes[i]}");
                    Console.WriteLine($"Level: {levels[i]}");

                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine($"Course {j + 1}: {scores[i, j]}");
                        total += scores[i, j];
                    }

                    double average = total / 5.0;

                    string grade;

                    if (average >= 80)
                        grade = "A";
                    else if (average >= 70)
                        grade = "B";
                    else if (average >= 60)
                        grade = "C";
                    else if (average >= 50)
                        grade = "D";
                    else
                        grade = "F";

                    string status;

                    if (average >= 50)
                        status = "Passed";
                    else
                        status = "Failed";

                    Console.WriteLine($"Total: {total}");
                    Console.WriteLine($"Average: {average:F1}");
                    Console.WriteLine($"Grade: {grade}");
                    Console.WriteLine($"Status: {status}");
                }



            else if (choice == 3)
                {
                    Console.WriteLine("Thank you for using the Student Results Processing System.");
                }

                else
                {
                    Console.WriteLine("Invalid option.");
                }

            } while (choice != 3) ;
        }
}
