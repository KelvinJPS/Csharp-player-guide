
int[] userNumbers = new int[5];

Console.WriteLine("input numbers");

for(int i = 0; i < 5; i++)
{
    Console.WriteLine("input number");
    int n = Convert.ToInt32(Console.ReadLine());
    userNumbers[i] = n;

}
// copy values 
int [] userNumbersCopy = new int[userNumbers.Length];

for (int i = 0; i < userNumbers.Length; i++)
{
    userNumbersCopy[i] = userNumbers[i];
}

for (int index = 0; index < 5; index++)
    Console.WriteLine($"{userNumbers[index]} and {userNumbersCopy[index]}");
