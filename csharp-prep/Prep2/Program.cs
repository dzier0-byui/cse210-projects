using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        if (grade >= 90){
            letter = "A";
        }
        else if (grade >= 80){
            letter = "B";
        }
        else if (grade >= 70){
            letter = "C";
        }
        else if (grade >= 60){
            letter = "D";
        }
        else {
            letter = "F";
        }

        int lastDigit = grade % 10;
        if (lastDigit >= 7 && letter != "A" && letter != "F"){
            letter += "+";
        }
        else if (lastDigit < 3 && letter != "F"){
            letter += "-";
        }

        Console.WriteLine($"Your grade is {letter} at {grade}%");

        if (grade >= 70){
            Console.WriteLine("Congrats you passed!!");
        }
        else{
            Console.WriteLine("You did not pass");
        }
    }
}