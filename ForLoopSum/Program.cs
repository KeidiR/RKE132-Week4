//

int sum = 0;
for(int i = 1; i < 11; i++)
{
    Console.WriteLine($"i = {i}");//{i + 1} ei muuda i väärtust, ainult muudab 
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; //sum += i;
}

Console.WriteLine($"Final total {sum}");

//tagurpidi lugemine
for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"i = {i}");//{i + 1} ei muuda i väärtust, ainult muudab 
    Console.WriteLine($"Current total: {sum}");
    sum = sum - i; //sum -= i;
}

Console.WriteLine($"Final total {sum}");

// for(int i = 1; i < 11; i++) loetleb 1-10
//{
//Console.WriteLine($"i = {i}");
//}