//Задача 10: Напишите метод, который принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

void MyMethod()
{
    Console.Write("введите трехзначное число: ");
    string str = (Console.ReadLine());
    Console.WriteLine(str[1]);
}

MyMethod();
