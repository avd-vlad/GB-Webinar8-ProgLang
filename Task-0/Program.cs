/*------------------------------------------------------------------------------------------------------------------
Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if( row1>=0 && row1 < array.GetLength(0) &&
        row2>=0 && row1 < array.GetLength(0) &&
        row1!=row2)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1,j] = array[row2, j];
            array[row2,j] = temp;
        }    
    return array;
}

int[,] myArr = CreateRandom2dArray();
Show2dArray(myArr);
Show2dArray(ChangeRows(myArr, 2, 5));