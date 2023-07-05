// Допущение для всех задач: Пользователь вводит адекватные значение 
// (если в условии задачи написано "возводит число A в натуральную степень B", то мы допускаем, 
// что число B на вход мы получим натуральное, а вот А может быть любое, иначе придется использовать слишком много проверок)

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.WriteLine("Task 47:");
Console.WriteLine();

double[,] CreateArray(int row, int col)
{
    double[,] arr = new double[row, col];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().NextDouble() * 10;
        }

    return arr;

}

void ShowArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0:f1} ", arr[i,j]);
        }
        Console.WriteLine();

    }
}

Console.Write("Enter amount of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter amount of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[row, col];
arr = CreateArray(row, col);
ShowArray(arr);