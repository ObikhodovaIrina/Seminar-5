//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
    }
}

void PrintArray (int[] array)
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
int sum = 0;
for (int i = 1; i < array.Length; i++)
{
    sum = array[i] + sum;
    i++;
}

Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях индекса = {sum}");
