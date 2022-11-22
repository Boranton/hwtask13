// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("ВВести число : ");
int number = Convert.ToInt32(Console.ReadLine());
// int digit1 = number/10; // 72 / 10 = 7
// int digit2 = number%10; // 72 % 10 = 2
if(number>=100 && number<=999)
{
    Console.WriteLine(number%10);
}
else if (number <=99)
{
    Console.WriteLine("третьей цифры нет");
}

else if (number >=10000 && number <=99999)
{
    Console.WriteLine(number = number/100%10);
}

else
{
    Console.WriteLine("таких чисел нет в условии");
}