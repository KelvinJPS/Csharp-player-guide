
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
Console.WriteLine("What is your name ");
string name = Console.ReadLine();

// prices
int ropePrice = 10;
int torchesPrice = 15;
int climbingEquipmentPrice = 25;
int cleanWaterPrice = 1;
int machetePrice = 20;
int canoePrice = 200;
int foodSuppliesPrice = 1;

string itemName = "";
double itemPrice = 0;
double discount = 50;
switch (userItem)
{
    case 1: 
        itemName = "Rope";
        itemPrice = ropePrice;
        break;
    
    case 2:
        itemName = "Torches";
        itemPrice = torchesPrice;
        break;

    case 3:
        itemName = "Climbing Equipment";
        itemPrice = climbingEquipmentPrice;
        break;

    case 4:
        itemName  = "Clean Water";
        itemPrice = cleanWaterPrice; 
        break;

    case 5:
        itemName = "Machete";
        itemPrice = machetePrice;
        break;

    case 6:
        itemName = "Canoe";
        itemPrice = canoePrice;
        break;

    case 7:
        itemName = "Food Supplies";
        itemPrice = foodSuppliesPrice;
        break;


}

if (name == "Kelvin")
{
    discount =  discount / 100;
    discount = itemPrice *  discount;
    itemPrice =  itemPrice - discount;
}

Console.WriteLine( itemName + " cost: " + itemPrice );

