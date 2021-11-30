//No 45 specified number in a given array of integers

int[] array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9, 5, 5, 5 };
Console.Write("Enter A Number : ");
int x = Convert.ToInt32(Console.ReadLine());

int appearrance = array1.Count(n => n == x);

Console.Write("The Number of Appearance of " + x + " in given array is: " + appearrance);
