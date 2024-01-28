
// Get x and y from user
Console.WriteLine("Provide value of x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Provide value of y:");
int y = Convert.ToInt32(Console.ReadLine());

if (y < 0)
{
    if (x < 0)
    {
        Console.WriteLine("The enemy is to the southwest");
    }
    else if (x == 0)
    {
        Console.WriteLine("The enemy is to the south");
    }
    else if (x > 0)
    {
        Console.WriteLine("The enemy is to the southeast");

    }
}
else if (y == 0)
{
    if (x < 0)
    {
        Console.WriteLine("The enemy is to the west");
    }
    else if (x == 0)
    {
        Console.WriteLine("The enemy is here");
    }
    else if (x > 0)
    {
        Console.WriteLine("The enemy is to the east");

    }
}

else if (y > 0)
{
    if (x < 0)
    {
        Console.WriteLine("The enemy is to the northwest");
    }
    else if (x == 0)
    {
        Console.WriteLine("The enemy is to north");
    }
    else if (x > 0)
    {
        Console.WriteLine("The enemy is to the northeast");

    }
}
  



    

