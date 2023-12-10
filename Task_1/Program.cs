// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] Create2dArray(int row, int col, int min, int max){
    int [,] array = new int [row,col];
    for (int i =0; i<row; i++){
        for(int j = 0; j<col;j++){
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void ElementPosition(int [,] array, int row, int col) {
    if (row < array.GetLength(0) && col < array.GetLength(1)) {
        int res = array[row, col];
        Console.WriteLine($"Элемент двумерного массива с позицией {row}, {col} равен {res}");
    } else {
        Console.WriteLine("Элемента с таким индексом нет в двумерном массиве");
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

Console.WriteLine("Enter position row");
int rowPos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter position col");
int colPos = Convert.ToInt32(Console.ReadLine());


int [,] created2dArray = Create2dArray(row,col,min,max);
Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
ElementPosition(created2dArray, rowPos, colPos);