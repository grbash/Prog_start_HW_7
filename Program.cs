// Допущение для всех задач: Пользователь вводит адекватные значение 
// (если в условии задачи написано "возводит число A в натуральную степень B", то мы допускаем, 
// что число B на вход мы получим натуральное, а вот А может быть любое, иначе придется использовать слишком много проверок)

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine("Task 47:");
Console.WriteLine();

int[,] CreateArray(int row, int col)
{
    int[,] arr = new int[row, col];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(-10, 11);
        }

    return arr;

}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();

    }
}

void FindElement(int row, int col, int[,] arr)
{
    if (row >= arr.GetLength(0) || col >= arr.GetLength(1))
        Console.WriteLine($"There is no element with this index [{row}, {col}]");
    else
        Console.WriteLine($"Ur element is [{arr[row,col]}]");
}



Console.Write("Enter amount of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter amount of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[row, col];
arr = CreateArray(row, col);

Console.WriteLine("Ur arr: ");
ShowArray(arr);

Console.Write("Enter number of row (Rows start from 0!): ");
int rowToFind = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of column (Columns start from 0): ");
int colToFind = Convert.ToInt32(Console.ReadLine());

FindElement(rowToFind, colToFind, arr);

