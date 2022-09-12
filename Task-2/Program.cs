/*------------------------------------------------------------------------------------------------------------------
Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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
void ShowArr(int[] arr)
{

    Console.Write("[");
    for(int i=0; i<arr.Length;i++)
        if(i==arr.Length-1)
            Console.Write($"{arr[i]} ]");
        else
            Console.Write($"{arr[i]}, ");
    Console.WriteLine();
}

int[] FindMin(int[,] sourceArr)
{
    int minRow=0, minCol=0, min=sourceArr[0, 0];
    int[] res = {0, 0};
    
    for(int i = 0; i < sourceArr.GetLength(0); i++)
        for(int j =0; j < sourceArr.GetLength(1); j++)
            if(sourceArr[i,j]<min)
            {
                min = sourceArr[i,j];
                minRow = i;
                minCol = j;
            }
    res[0] = minRow;
    res[1] = minCol;

    return res;
}


int[,] Truncate(int[,] sourceArr)
{
    int[] minInd = new int[2];
    int rows, cols;
    rows = sourceArr.GetLength(0);
    cols = sourceArr.GetLength(1);

    int[,] resArr = new int[rows-1, cols-1];
    minInd = FindMin(sourceArr);
    
    int iInc=0, jInc=0;
    
    for(int i = 0; i < sourceArr.GetLength(0); i++)
    {
        jInc = 0;
        if(i==minInd[0])
        {   
            iInc = 1;
            continue;
        }
        for(int j =0; j < sourceArr.GetLength(1); j++)
        {
            if(j==minInd[1])
            {   
                jInc = 1;
                continue;
            }
            resArr[i-iInc,j-jInc] = sourceArr[i,j];
        }
    }
    return resArr;
}

int[,] myArr=CreateRandom2dArray();
Show2dArray(myArr);
ShowArr(FindMin(myArr));
Show2dArray(Truncate(myArr));