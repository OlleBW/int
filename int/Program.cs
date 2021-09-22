using System;

int Points = 0;

Console.WriteLine("Welcome To My Math Quiz!");
Console.WriteLine("Are you ready?");
Console.ReadLine();
Console.WriteLine("You are ready.");
Console.WriteLine("What is 1 + 2?");

string Answer1 = Console.ReadLine();

if (Answer1 == "3")
{
    Console.WriteLine("Congratulations! You answered RIGHT and got 10 points.");
    Points = Points + 10;
    Console.WriteLine("This next question is a bit more difficult.");
    Console.WriteLine("Are you ready?");
    Console.ReadLine();
    Console.WriteLine("Of course you are!");
    Console.WriteLine("What is 16 + 20?");

    
    string Answer2 = Console.ReadLine();
    if (Answer2 == "36")
    {
        Console.WriteLine("That was Correct! You got 20 points");
        Points = Points + 20;
        Console.WriteLine("Now for the last question");
        Console.WriteLine("Are you ready?");
        Console.ReadLine();
        Console.WriteLine("9817*783");
        string Answer3 = Console.ReadLine();

        while (Answer3 != "7686711")
        {
            Console.WriteLine("Try again.");
            Console.ReadLine();
        }
        if (Answer3 == "7686711")
        {
            Console.WriteLine("Congratulations! You got the right answer and was awarded with 7686711 points");
            Points = Points + 7686711;
            Console.WriteLine("You passed the math quiz with a total of " + Points + " points");
        }
         
    }
    else
    {
        Console.WriteLine("That was wrong! Shame on you!");
        Console.WriteLine("You failed the quiz with a total of 10 points.");
    }
}
else
{
    Console.WriteLine("That was very incorrect. You failed!");
    Console.WriteLine("You got a total of 0 points");
}

Console.ReadLine();