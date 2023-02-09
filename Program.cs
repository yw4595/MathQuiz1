using System;

/// <summary>
/// Class for a math quiz program
/// Author: [Your Name]
/// Purpose: To generate random math questions and keep track of the number of correct answers
/// Restrictions: None
/// </summary>
class Program
{
    /// <summary>
    /// Main method to run the math quiz program
    /// Purpose: To take input from the user, generate random math questions, keep track of the number of correct answers, and display the results
    /// Restrictions: None
    /// </summary>
    static void Main()
    {
        string name;
        int questions;
        int difficulty;
        int correct = 0;
        int answer;
        int response;
        Random rand = new Random();
        bool valid = false;

        Console.WriteLine("Math Quiz!");
        Console.Write("What is your name-> ");
        name = Console.ReadLine();

        Console.Write("How many questions-> ");
        questions = int.Parse(Console.ReadLine());
        Console.Write("Difficulty level (1-3)-> ");
        difficulty = int.Parse(Console.ReadLine());

        for (int i = 0; i < questions; i++)
        {
            int num1 = rand.Next(1, (difficulty * 10));
            int num2 = rand.Next(1, (difficulty * 10));
            int operation = rand.Next(0, 3);
            if (operation == 0)
            {
                answer = num1 + num2;
                Console.WriteLine($"Question #{i + 1}: {num1} + {num2} = ");
            }
            else if (operation == 1)
            {
                answer = num1 - num2;
                Console.WriteLine($"Question #{i + 1}: {num1} - {num2} = ");
            }
            else
            {
                answer = num1 * num2;
                Console.WriteLine($"Question #{i + 1}: {num1} * {num2} = ");
            }
            int timeLeft = 5;
            Console.WriteLine("You have 5 seconds to answer.");
            while (timeLeft > 0)
            {
                if (Console.KeyAvailable)
                {
                    response = int.Parse(Console.ReadLine());
                    if (response == answer)
                    {
                        correct++;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Time left: " + timeLeft);
                    System.Threading.Thread.Sleep(1000);
                    timeLeft--;
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine($"{name}, you got {correct} out of {questions} correct.");
    }
}
