int pilotNumber;
int hunterNumber;

do
{
    
    Console.WriteLine("pick a number between 0 - 100");
    pilotNumber = Convert.ToInt32(Console.ReadLine());
}
while (pilotNumber < 0 || pilotNumber > 100);

do
{

    Console.WriteLine("Guess the pilot's number");
    hunterNumber = Convert.ToInt32(Console.ReadLine());

    if (hunterNumber > pilotNumber)
    {
        Console.WriteLine("Too high");
    }

    else if (hunterNumber < pilotNumber)
    {
        Console.WriteLine("Too low");
    }
    
    else
    {
        Console.WriteLine("You guessed the number");
    }

}
while (hunterNumber != pilotNumber);

