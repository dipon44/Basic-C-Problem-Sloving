
for(; ; )
{
    Console.Write("Enter First Value : ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Second Value : ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Third Value : ");
    int z = Convert.ToInt32(Console.ReadLine());

    if (x > y && x > z)
    {
        Console.Write("{0} is the biggest Value", x);
    }

    if (y > z && y > z)
    {
        Console.Write("{0} is the biggest Value", y);
    }

    if (z > x && z > y)

    {
        Console.Write("{0} is the biggest Value", z);
    }

    Console.Write(" and ");

    if (x < y && y < z)
    {
        Console.Write("{0} is the smallest Value. \n\n", x);
    }

    if (y < z && z < x)
    {
        Console.Write("{0} is the smallest Value. \n\n", y);
    }

    if (z < x && x < y)
    {
        Console.Write("{0} is the smallest Value. \n\n", z);
    }

    
}
 


