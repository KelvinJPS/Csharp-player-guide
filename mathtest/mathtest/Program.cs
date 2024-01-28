// See https://aka.ms/new-console-template for more information
int a = 4; 
int b = 5;
var  result =  (float) b / a;
Console.WriteLine(result);

/// 
int health = 0;
health += 120; 
health = Math.Clamp(health, 0, 100); // Keep it in the interval 0 to 100.
Console.WriteLine(health);
// with clamp it doesn't go up that value 
