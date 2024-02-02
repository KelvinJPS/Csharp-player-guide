// Fire blast ocurr at  the 3th turn and electric blast occur at the 5th, indexer ar initialized on the loop and incremented. 

for (int i = 1;  i < 100; i++)
{

    if( i % 3  == 0 && i % 5 == 0 )
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Electric and fire");
    }
    
   else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire");
    }

    else if (i == 5)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Electric");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Normal");
    }
    }


