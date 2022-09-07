// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 999 + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"\nThere are {count} even numbers!");    
}
Console.WriteLine("Input the size of a random array: ");
int evnum = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(evnum));
