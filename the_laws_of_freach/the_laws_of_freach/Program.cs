int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;

for (int index = 0; index < array.Length; index++)
foreach (int inder in array)
        total += array[index];

float average = (float)total / array.Length;
Console.WriteLine(average);