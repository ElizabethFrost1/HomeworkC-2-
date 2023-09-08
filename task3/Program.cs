// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine ("Enter number of the day: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

    if (num == 6) 
    {
        Console.WriteLine ("YES! It's a weekend!");
    }
    else if (num ==7)
    {
        Console.WriteLine ("YES! It's a weekend!");
    }

    else if (num < 6)
    {
         Console.WriteLine("No! Is's a weekday!");
    }
   if (num > 7)
   {
Console.WriteLine ("There are only 7 days in a week!");
   }