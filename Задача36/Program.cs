// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine();
Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами.");
Console.WriteLine();

void FillAray1 (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next (-100,999);
        Console.Write(arr [i] + " "); 
    }
}

int[] arrey = new int[4];
FillAray1(arrey);
Console.WriteLine();
int lengthe = arrey.Length;
int count1 = 0; 

for (int i = 0; i < lengthe; i++)
{
    if (i % 2 != 0)
    {
        count1 = count1 + arrey[i];
    }
}

Console.WriteLine(" ");
Console.WriteLine("Сумму элементов, стоящих на нечётных позициях: " + count1);
