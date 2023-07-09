//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными(тип double) числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


Console.Write("Введите количество строк: "); 
int rows = int.Parse(Console.ReadLine()!); 
 
Console.Write("Введите количество столбцов: "); 
int columns = int.Parse(Console.ReadLine()!); 
 
double[,] array = GetArray(rows, columns, -99, 100); 
PrintArray(array); 

//метод заполнениядвумерного массива
double[,] GetArray(int m, int n, int minValue, int maxValue){ 
    double[,] result = new double[m,n]; 
    for(int i = 0; i < m; i++){ 
        for(int j = 0; j < n; j++){ 
            result[i,j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
        } 
    } 
    return result; 
} 
 
//метод вывода дмумерного массива
void PrintArray(double[,] inArray){ 
    for(int i = 0; i < inArray.GetLength(0); i++){ 
        for(int j = 0; j < inArray.GetLength(1); j++){ 
            Console.Write($"{inArray[i,j]:f1} "); 
        } 
        Console.WriteLine(); 
    } 
}