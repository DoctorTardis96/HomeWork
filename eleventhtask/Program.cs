

void MyMethod()
{
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    Console.WriteLine(sum);
}
MyMethod();