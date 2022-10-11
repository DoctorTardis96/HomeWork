/* Задача 29: Напишите метод, который задаёт массив из 8 элементов и выводит их на экран. */
class Program
{

    static void Main(string[] args)
    {
/*         Console.Write("Введите колличество элементов массива:\t");
        
        int n = int.Parse(Console.ReadLine()); */
        
        int[] array = new int[8];
        Random rand = new Random();
        for (int i = 0; i < 8; i++)
        {
            array[i] = rand.Next(0, 8);
        }
         
/*         for (int i = 0; i < array.Length; i++)
        {
            Console.Write ($"\nВведите элемент массива под индексом {i}:\t ");
            array[i] = int.Parse(Console.ReadLine());
        } */
        Console.WriteLine("\nВывод массива:");
        
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+ ",");
        }
    }



}
