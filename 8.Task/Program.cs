/* Задача 19 Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом. */


int num, temp, revNum = 0, rem;
Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
temp = num;
while (num > 0)
{
    rem = num % 10;
    revNum = revNum * 10 + rem;
    num = num / 10;
}
if (revNum == temp)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}

