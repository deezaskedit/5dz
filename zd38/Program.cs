// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. NextDouble() - не принимает аргументов. Генерирует случайное вещественное числов в диапазоне от нуля до единицы. Сумма next + next double. double[] - массив вещественных чисел.

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];

    for(int i = 0; i < size; i++)
        newArray[i] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
        if (array[i] > max) max = array[i]; 
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"\nThe difference between {max} and {min} is {max - min}.");
}

Console.WriteLine("Input the size of random array, low limit, upper limit: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(size, min, max));