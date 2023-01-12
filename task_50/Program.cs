/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:*/
void InputMatrix(int [,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(-10, 10);
             Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[5, 5];
InputMatrix(matrix);
Console.Write("Введите позицию ячейки через пробел: ");
int[] pos = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//int[,] matrix = new int[pos[0], pos[1]];
if(pos[0] < matrix.GetLength(0) && pos[1] < matrix.GetLength(1)){
    Console.WriteLine(matrix[pos[0] - 1, pos[1] - 1]);
}
else Console.WriteLine("Вне массива");