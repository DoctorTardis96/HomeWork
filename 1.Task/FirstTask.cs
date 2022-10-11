//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
//а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое значение: ");
var n1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе значение: ");
            var n2 = int.Parse(Console.ReadLine());
            if ( n1 > n2 ){
                 Console.Write("Максимальное значение введенных чисел найдено: ");
                Console.WriteLine( n1 );
            }
            else {
                Console.Write("Максимальное значение введенных чисел найдено: ");
                Console.WriteLine( n2 );
            }