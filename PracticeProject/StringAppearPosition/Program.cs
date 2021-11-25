
//No 37
Console.WriteLine("Enter A String : ");
string input = Console.ReadLine();

Console.WriteLine((input.Substring(1, 2).Equals("HP") ? input.Remove(1, 2) : input));