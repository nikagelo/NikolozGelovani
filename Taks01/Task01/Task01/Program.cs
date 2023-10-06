Random random = new Random();
int randNum = random.Next(1, 11);
int tries = 3;
Console.WriteLine("Try to guess a number from 1 to 10");
for (int i = 0; i < tries; i++)
{
    int guess;
    int.TryParse(Console.ReadLine(), out guess);

    if (guess == randNum)
    {
        Console.WriteLine("You won");
        break;
    }
    else if (i == 2)
    {
        Console.WriteLine("Wrong. It was " + randNum);
    }
    else
    {
        Console.WriteLine("Wrong, try again");
    }
}
