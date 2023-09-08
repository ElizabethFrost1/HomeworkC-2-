// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine ("Enter nember: ");
string number1 = Console.ReadLine();
int num = int.Parse(number1);

int num1 = num / 100;
int num2 = (num - (num1 * 100)) / 10;

if (num > 99 && num < 1000)
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("Enter three-digit number!");
}
