/* Objectives: 
• Create a program that allows users to enter how many provinces, duchies, and estates they have. 
• Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province. 
• Display the point total to the user.*/

int provinceScore = 6;
int duchyScore = 3;
int estateScore = 1;

Console.WriteLine("How many provinces do you have");
int userProvinces = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many duchies do you have:");
int userDuchies = Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("How many estates do you have:");
int userEstates = Convert.ToInt32(Console.ReadLine());

int UserTotalScore = (userProvinces * provinceScore)  + ( userDuchies * duchyScore) + (userEstates * estateScore);

Console.WriteLine(UserTotalScore);
