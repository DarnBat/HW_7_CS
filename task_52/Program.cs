// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix(int [,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(-10, 10);
             Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m,n];
InputMatrix(matrix);
for(int i = 0; i < matrix.GetLength(0); i++){
    double avg = 0;
    for(int j = 0; j < matrix.GetLength(1); j++){
        avg += matrix[i, j];
    }
    Console.Write($"{Math.Round(avg / m, 2)} ");
}