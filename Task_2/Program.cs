// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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

// int [,] CreateChanged2dArray (int [,] array) {
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j=0; j<array.GetLength(1); j++){
            
            
//         }
//     }
//     return array;
// }

void ShowChanged2dArray(int [,] array) {

    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    // Console.WriteLine(rows);


    for (int i = 0; i < cols; i++) {
        int temp = array[0, i];
        array[0, i] = array[rows - 1, i];
        array[rows - 1, i] = temp;
    }


    Console.WriteLine("Массив после изменений");
    for(int i = 0; i<rows; i++){
        for(int j=0; j<cols; j++){
            Console.Write(array[i,j]+" ");

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


int [,] created2dArray = Create2dArray(row,col,min,max);
Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
ShowChanged2dArray(created2dArray);