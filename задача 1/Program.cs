//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void FillArray(int[] randomArray)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(100, 1000);
    }
}

void WriteArray(int[] randomArray)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        Console.Write(randomArray[i] + " ");
    }
}


int[] randomArray = new int[10];
FillArray(randomArray);
Console.WriteLine("Задан случайный массив");
WriteArray(randomArray);
int count = 0;
for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] %2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {count}");
