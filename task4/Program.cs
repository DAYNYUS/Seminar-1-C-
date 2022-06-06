/*7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/    

Console.Clear();


Console.Write("Введите трёхзначное число:");

string input = Console.ReadLine(); 
int number = Convert.ToInt32(input);

if (number > 99 && number < 1000)
{
int a = number % 10;
Console.WriteLine(a);
}
else 
{
 Console.WriteLine("ОШИБКА! Введено некорректное число!");   
}

