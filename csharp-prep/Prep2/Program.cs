using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        string letterGrade;
        bool again = true;
        while (again)
        {
            Console.Write("Enter a  numeric grade between 0 & 100 inclusive: ");
            grade = int.Parse(Console.ReadLine());
            if (grade < 60)
            {
                letterGrade = "F";
            }
            else if (grade < 70)
            {
                letterGrade = "D";
            }
            else if (grade < 80)
            {
                letterGrade = "C";
            }
            else if (grade < 90)
            {
                letterGrade = "B";
            }
            else
            {
                letterGrade = "A";
            }
            if (letterGrade != "F" && grade < 100) // specs say no F- or F+, and modulus operator is only valid for grades less than 100
            {
                if (grade % 10 >= 7)
                {
                    if (letterGrade != "A") //spec say no A+
                    {
                        letterGrade += "+";
                    }
                }
                else if (grade % 10 < 3)
                {
                    {
                        letterGrade += "-";
                    }
                }
            }
            Console.WriteLine($"The letter grade is {letterGrade}");
            Console.Write("Would you like to enter another grade? (y/n) ");
            string response = Console.ReadLine();
            if (response == "n")
            {
                again = false;
            }
            else
            {
                Console.Write("\n");
            }
        }
    }
}