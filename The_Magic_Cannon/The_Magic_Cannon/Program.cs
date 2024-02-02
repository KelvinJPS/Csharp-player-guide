
for (int i = 1, fireI = 1, electricI = 1; i < 100; i++, fireI++, electricI++)
{
    if (fireI == 3)
    {
        Console.WriteLine("Fire");
        fireI = 0;
    }

    else if (electricI == 5)
    {
        Console.WriteLine("Electric");
        electricI = 0;
    }
    else
    {
        Console.WriteLine("Normal");
    }
    // Reset fireI and electricI After every 10 iterations

    if (i % 10 == 0)
    {
        fireI = 1;
        electricI = 1;
    }
}


