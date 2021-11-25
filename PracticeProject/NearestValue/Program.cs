//No 40 Nearest Value

Console.Write("Enter the Basement Value : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Basement Value is {0}", x);

int y, z;

Console.WriteLine("Enter y Value : ");
y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter z Value : ");
z = Convert.ToInt32(Console.ReadLine());

int value1 = x - y;
int value2 = x - z;

if(y==z)
{
    Console.WriteLine("Error!");
}
else
{
    if(value1>value2)
    {
        Console.WriteLine("{0} is the Nearest value of {1} ", z, x);
    }
    if (value2 > value1)
    {
        Console.WriteLine("{0} is the Nearest value of {1} ", y, x);
    }
}