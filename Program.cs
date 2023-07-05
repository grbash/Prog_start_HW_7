// Допущение для всех задач: Пользователь вводит адекватные значение 
// (если в условии задачи написано "возводит число A в натуральную степень B", то мы допускаем, 
// что число B на вход мы получим натуральное, а вот А может быть любое, иначе придется использовать слишком много проверок)

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 


Console.WriteLine("Task 52:");
Console.WriteLine();

int[,] CreateArray(int row, int col)
{
    int[,] arr = new int[row, col];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(-row, col + 1);
        }

    return arr;

}

void ShowMainArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();

    }
}

void ShowResArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        Console.Write("{0:f3}, ", arr[i]);
    }
    Console.Write("{0:f3}]", arr[arr.GetLength(0) - 1]);
}

double [] ArithmeticMean(int [,] arr)
{
    double [] resultArray = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            resultArray[i] += arr[j,i];
        }
        resultArray[i] /= arr.GetLength(0);
    }

    return resultArray;

}


Console.Write("Enter amount of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter amount of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[row, col];
arr = CreateArray(row, col);

Console.WriteLine("Ur arr:");
ShowMainArray(arr);

//double resultArray = new double [arr.GetLength(1)];
double [] resultArray = ArithmeticMean(arr);

Console.WriteLine("Arithmetic mean of each column: ");
ShowResArray(resultArray);