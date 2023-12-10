// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


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


int ChangedArray(int [,] array) {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    int [] myarray = new int [array.GetLength(0)];

    for (int i = 0; i < rows; i++) {
        int res = 0;
        for (int j = 0; j < cols; j++) {
            res = res + array[i, j];
        }
        myarray[i] = res;
    }

    int minValue = myarray[0];
    int minIndex = 0;

    for (int i = 0; i < myarray.Length; i++) {
        if (minValue > myarray[i]) {
            minValue = myarray[i];
            minIndex = i;
        }
    }

    return minIndex;
}


Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());


int [,] created2dArray = Create2dArray(row,col,min,max);
Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
int res = ChangedArray(created2dArray);
Console.WriteLine($"Строка с наименьшей суммой элементов с индексом = {res}");
