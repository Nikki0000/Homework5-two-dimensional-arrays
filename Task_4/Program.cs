// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца


int[,] Create2dArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ChangedArray(int[,] array)
{
    int min = array[0, 0];
    int rowIndex = 0;
    int colIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                rowIndex = i;
                colIndex = j;
                min = array[i, j];
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, colIndex] = 0;
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[rowIndex, j] = 0;
    }
    return array;
}

void ShowChanged2dArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    int min = array[0, 0];
    int rowIndex = 0;
    int colIndex = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (min > array[i, j])
            {
                rowIndex = i;
                colIndex = j;
                min = array[i, j];
            }
        }
    }

    int[,] newArray = new int[rows - 1, cols - 1];

    int newRow = 0;
    int newCol = 0;

    for (int i = 0; i < rows; i++)
    {
        if (array[i, 0] == 0)
        {
            continue;
        }

        newCol = 0;

        for (int j = 0; j < cols; j++)
        {
            if (array[0, j] == 0)
            {
                continue;
            }

            newArray[newRow, newCol] = array[i, j];
            newCol++;
        }

        newRow++;
    }

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write(newArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] created2dArray = Create2dArray(row, col, min, max);
Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
int[,] changedArray = ChangedArray(created2dArray);
Show2dArray(changedArray);
Console.WriteLine();
ShowChanged2dArray(changedArray);