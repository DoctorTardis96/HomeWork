degree();

void degree()
{
    double a;
    double b;
    Double c;
    Console.WriteLine("Введите число: ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите степень: ");
    b = Convert.ToDouble(Console.ReadLine());
    c = Math.Pow(a, b);
    Console.WriteLine("Число " + a + " в степени " + b + " равно " + c + "!");
}

