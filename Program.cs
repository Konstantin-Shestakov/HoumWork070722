// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

 
int[] CreateRandomArray(int size, int min, int max)
{
    
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    
}
Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(num, 100, 999);
 ShowArray(myArray);
int N = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0)
    {
        N++;
    }
}
Console.Write(" ->  " +N);
*/


//  Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int min, int max)
// {
    
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
    
// }
// Console.Write("Введите число с которого начинаются элементы массива [A]: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число которым заканчиваются элементы массива [B]: ");
// int end = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество случайных элементов массива [A,.....,B]: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(num, start, end);
//  ShowArray(myArray);
// int N = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if (i % 2 == 0)
//     {
//         N = N +myArray[i];
        
//     }
// }
// Console.Write($" ->  {N}  сумма элементов, стоящих на нечётных позициях");



//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// int[] CreateRandomArray(int size, int min, int max)
// {
    
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
    
// }

// Console.Write("Введите число с которого начинаются элементы массива [A]: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число которым заканчиваются элементы массива [B]: ");
// int end = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество случайных элементов массива [A,B]: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(num, start, end);
//  ShowArray(myArray);
// int MinNumber = myArray[0];
// int MaxNumber = myArray[0];
//     for (int i = 0; i < myArray.Length; i++)
// {
    
//     if (myArray [i] <= MinNumber)
//     {
//         MinNumber = myArray[i];
      
//     }
//        if (myArray[i] >= MaxNumber)
//     {
//         MaxNumber = myArray [i];
//     }
// }
// Console.Write($" ->  {MaxNumber}-{MinNumber} = {MaxNumber - MinNumber} разница между max и min значениями элемнтов массива");

