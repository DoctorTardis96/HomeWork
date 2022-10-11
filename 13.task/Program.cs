/* Задача 25: опишите метод, который принимает на вход два числа (A и B) 
и возводит число A в целую степень B. */

static void MyMethod()
{
    Console.WriteLine("\nВведите число которое хотите возвести в степень:\t");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("\nВведите степень, в которую хотите возвести число:\t");
    int b = int.Parse(Console.ReadLine());
    int i = 0;
    int sum = 1;
    while(i < b)
    {
        i++;
        sum *= a;
        
    }
    Console.WriteLine(sum);
}
MyMethod();