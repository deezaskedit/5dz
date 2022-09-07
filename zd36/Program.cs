// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (i % 2 == 1) sum += array[i];
    }
    Console.WriteLine($"\n The sum is {sum}!");    
}
Console.WriteLine("Input the size of random array, low limit, upper limit: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(size, min, max));
