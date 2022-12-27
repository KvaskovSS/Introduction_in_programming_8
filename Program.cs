void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++){
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int[,] createAndFillMatr(){
    Console.WriteLine("Введите количество строк ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int col = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[line, col];

    for (int i = 0; i < numbers.GetLength(0); i++){
         for (int j = 0; j < numbers.GetLength(1); j++){
            numbers[i, j] = Convert.ToInt32(new Random().Next(-100, 100)) / 10;
        }
    }
    return numbers;
}

//Task 1
// void sortLines(int[,] arr){
//     Console.WriteLine("Исходный массив ");
//     PrintArray(arr);
//     int temp = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(1) - 1; k++)
//             {
//                 if (arr[i, k] < arr[i, k + 1])
//                 {
//                     temp = arr[i, k + 1];
//                     arr[i, k + 1] = arr[i, k];
//                     arr[i, k] = temp;
//                 }
//             }
//         }
//     }
//     Console.WriteLine("Измененный массив ");
//     PrintArray(arr);
// }

//Task 2
void findSumCol(int[,] arr){
    Console.WriteLine("Исходный массив ");
    PrintArray(arr);

    int sum = 0;
    int minSum = Int32.MaxValue;
    int minPos = 0;
    for(int i = 0; i < arr.GetLength(0); i ++){
        for(int j = 0; j < arr.GetLength(1); j ++){
            sum += arr[i, j];
        }   
        if(sum < minSum){
            minPos = i;
            minSum = sum;
        }
        sum = 0;
    }
     Console.WriteLine($"Строка с наименьшей суммой {minPos + 1}");
}

//Task 1
// int[,] arr = createAndFillMatr();
// sortLines(arr);

//Task 2
int[,] arr = createAndFillMatr();
findSumCol(arr);