/*------------------------------------------------------------------------------------------------------------------
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
------------------------------------------------------------------------------------------------------------------*/
int[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];

    for(int i = 0; i< rows; i++)
        for(int j = 0; j < cols; j++)
            newArray[i,j] = new Random().Next(min, max);
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();

    }
    Console.WriteLine();

}

int[,] Transpose(int[,] sourceArr)
{
    int rows = sourceArr.GetLength(0);
    int cols = sourceArr.GetLength(1);
    int[,] newArr = new int[cols, rows];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
            newArr[j,i] = sourceArr[i,j];

    return newArr;
}


int[,] myArr=CreateRandom2dArray();
Show2dArray(myArr);
Show2dArray(Transpose(myArr));