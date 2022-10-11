//Задача 4: Напишите программу, которая принимает на вход
//три числа и выдаёт максимальное из этих чисел.



Console.Write("Введите первое значение: ");
var n1 = int.Parse(Console.ReadLine());
    Console.Write("Введите второе значение: ");
    var n2 = int.Parse(Console.ReadLine());
        Console.Write("Введите третье значение: ");
        var n3 = int.Parse(Console.ReadLine());
int max = n1;      
if ( n2 > max ) max = n2;
if ( n3 > max ) max = n3;
Console.Write("Максимальное значение из введенных чисел: ");
Console.WriteLine(max);
            
    
           
   

                