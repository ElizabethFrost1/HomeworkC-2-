// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter number: ");
string number = Console.ReadLine();
int num = int.Parse(number);

if (num < 99)
{
    Console.WriteLine("There is no third number!");
}

else if (num > 999)
{
while (num > 999)
{
 num = num / 10;
}
num = num % 10;
Console.WriteLine(num);
}
else if (num < 1000 && num > 99)
{
num = num % 10;
Console.WriteLine(num);
}
