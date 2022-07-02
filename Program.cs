/*int CalculateSum(int number)          //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
{
    int sum = 0;
    
    while(number > 0)      
    {      
        int m = number%10;      
        sum += m;      
        number = number / 10;      
    }     
    return sum;
}

Console.Write("Write a number: ");
var input = Console.ReadLine();
var isValidNumber = Int32.TryParse(input, out int number);

Console.WriteLine($"Sum of numbers is {CalculateSum(number)}");
*/
List<int> GetNumbers()                  //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
{
    var random = new Random();
    var list = new List<int>();

    for (int i = 1; i <= 8; i++) 
    {
        var randomNumber = random.Next(0, 1000);
        list.Add(randomNumber);
    }

    return list;
}

Console.WriteLine("Generated 8 numbers are: ");
foreach (var number in GetNumbers()) Console.WriteLine(number);