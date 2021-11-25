Console.Write("Enter A String : ");
string input = Console.ReadLine();
string result = "";

if (input.Length >= 1 && input[0] == 'P')
    result += input[0];
if (input.Length >= 2 && input[1] == 'H')
    result += input[1];
Console.WriteLine(result);

 
