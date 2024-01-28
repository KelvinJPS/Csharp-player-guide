/*
 * Objectives: • Take a number as input from the console. 
 * Display the word “Tick” if the number is even. 
 * Display the word “Tock” if the number is odd. 
 */
Console.WriteLine("insert number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}