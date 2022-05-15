//Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.
//[3, 7, 22, 2, 78] -> 76

void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] array = new int[8];
FillArray(array);
Console.WriteLine("Задан случайный массив");
PrintArray(array);
int maxNumber = 0;
int minNumber = array[0];
for (int i = 0; i < array.Length; i++)
{   
    if (maxNumber < array[i]) 
    {
        maxNumber = array[i];
    }
    else if (minNumber > array[i])
    {
        minNumber = array[i];
    }
}

int differentNumber = maxNumber - minNumber;

Console.WriteLine();
Console.WriteLine($"Разница большего элемента массива {maxNumber} и меньшнго {minNumber} = {differentNumber}");