int askForNumber (string text)
{
    Console.WriteLine (text);
    return Convert.ToInt32(Console.ReadLine());
}

int askForNumberInRange(string text, int min, int max)
{
    int number;
    do
    {
        Console.WriteLine(text);
        number = Convert.ToInt32(Console.ReadLine());
    }
    while (number < min || number > max);
    return number;
}

int result = askForNumber("What is the airspeed velocity of an unladen swallow?");
askForNumberInRange("Provide a number between 1-10", 1, 10);
