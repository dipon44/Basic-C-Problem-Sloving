//No 36 Range Check


for(; ; )
{
    int x, y;

    Console.Write("Enter The Range: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.Write("   ");
    y = Convert.ToInt32(Console.ReadLine());

    if (x > -10 && y < 10)
    {
        Console.WriteLine("{0} and {1} are in the Range of -10 to 10", x, y);
    }
    else
    {
        Console.WriteLine("{0} and {1} are not in the Range of -10 to 10", x, y);
    }
}




