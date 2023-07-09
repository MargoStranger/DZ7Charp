// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 2 -> 2
// i = 4, j = 2 -> такого элемента не существует

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 11);
PrintArray(array);

Console.Write("Какая строка вас интересует: ");
int elementI = int.Parse(Console.ReadLine()!);
Console.Write("Какой столбец вас интерсует: ");
int elementJ = int.Parse(Console.ReadLine()!);

GetElement(array,elementI,elementJ);
//Console.WriteLine($"Номер строки с минимальной суммой равен {ArrayMin(array)} ");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetElement(int[,] inArray, int elI, int elJ)
{
    
    if (elI > inArray.GetLength(0) || elJ > inArray.GetLength(1)) Console.WriteLine("Такого элемента нет");
    else Console.WriteLine($"Нужный вам элемент = {inArray[elI,elJ]}");

}