// Fire blast ocurr at  the 3th turn and electric blast occur at the 5th, indexer ar initialized on the loop and incremented. 

for (int i = 1;  i < 100; i++)
{
     // Electric and fire are at they desired value
    if( i % 3  == 0 && i % 5 == 0 )
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Electric and fire");
    }
    
    // each multiple of 3 
   else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire");
    }


    // each multiple of 5

    else if (i % 5 == 0)
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


