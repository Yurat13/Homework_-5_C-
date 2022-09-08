// Написать программу копирования массива

void FillArray (int[] mas)
{
    int index = 0;
    while (index < mas.Length)
    {
        mas[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray (int[] massiv)
{
    int i = 0;
    while (i < massiv.Length)
    {
        Console.Write($" {massiv[i]} ");
        i++;
    }
}

int[] array = new int [8];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int[] copy = new int[array.Length];
for(int i = 0; i < array.Length; i++)
{
    copy[i] = array[i];
    Console.Write($" {copy[i]} ");
}

// void copy (int[] matrix)
// {

// }