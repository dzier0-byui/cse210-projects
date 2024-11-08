using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess;
        int numberOfGuesses = 0;

        do{
            numberOfGuesses++;
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number){
                Console.WriteLine("Lower");
            }
            else if (guess < number){
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("you got it!!");
            }

        } while (guess != number);

        string guessWord = (numberOfGuesses > 1) ? "guesses" : "guess";
        Console.WriteLine($"It took you {numberOfGuesses} {guessWord}");
    }
}