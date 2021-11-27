// No 43 
Console.WriteLine("Enter a String : ");
string str = Console.ReadLine();

Console.WriteLine(test(str));

  static bool test(string str)
{
    var ctr = 0;
    for (var i = 0; i < str.Length - 1; i++)
    {
        if (str[i].Equals('w'))
        {
            ctr++;
        }
            
        if (str.Substring(i, 2).Equals("ww") && ctr > 2)
        {
            return true;
        }
            
    }
    return false;
}


