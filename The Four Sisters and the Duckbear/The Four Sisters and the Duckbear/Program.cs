Console.WriteLine("Eggs number");
int chocolateEggs  = Convert.ToInt32(Console.ReadLine());
int sistersCount = 4; 

int sistersEggs =  chocolateEggs / sistersCount;
int duckbeardEggs =  chocolateEggs % sistersCount;
Console.WriteLine("Each sister gets {0} and the duckbear {1}", sistersEggs, duckbeardEggs);

/*
Answer this question: What are three total egg counts where the duckbear gets more than each 
sister does? Yo u can use the program you created to help you find the answer. 
When there is less than 4 eggs the sister get 0 eggs and the duckbear gets all of them.
 */
