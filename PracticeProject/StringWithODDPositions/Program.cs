Console.WriteLine("Enter A String : ");
string str = Console.ReadLine();

var result = "";

for (var i = 0; i < str.Length; i++)
{
    if (i % 2 == 0)
    {
        result =result + str[i];
    }
       
}
Console.WriteLine(result);