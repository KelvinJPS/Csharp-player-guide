// A program that finds a name for things

/* Get the required info (Type and description) 
 for the program to find an appropiate name */
Console.WriteLine("What kind of thing are we talking about?"); 
string type = Console.ReadLine(); 

Console.WriteLine("How would you describe it? Big? Azure? Tattered?"); 
string description = Console.ReadLine(); 

// Name and current version of the program 
string name = "Doom";
string version = "3000"; 
Console.WriteLine("The " + type + " " + description + " of " + name + " " + version + "!");

