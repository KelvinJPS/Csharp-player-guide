
Console.WriteLine("The following items are available ");
Console.WriteLine("1 – Rope");
Console.WriteLine("2 – Torches");
Console.WriteLine("3 – Climbing Equipment");
Console.WriteLine("4 – Clean Water");
Console.WriteLine("5 – Machete");
Console.WriteLine("6 – Canoe");
Console.WriteLine("7 – Food Supplies");

Console.WriteLine("What number do you want to see the price of?");

int userItem = Convert.ToInt32(Console.ReadLine());

switch (userItem)
{
    case 1:
        Console.WriteLine("Rope:10 gold");
        break;

    case 2:
        Console.WriteLine("Torches: 15 gold");
        break;

    case 3:
        Console.WriteLine("Climbing Equipment: 25 gold");
        break;

    case 4:
        Console.WriteLine("Clean Water: 1 gold");
        break;
    case 5:
        Console.WriteLine("Machete: 20 gold");
        break;
    case 6:
        Console.WriteLine("Canoe: 200 gold");
        break;
    case 7:
        Console.WriteLine("Food Supplies: 1 gold");
        break;


}
