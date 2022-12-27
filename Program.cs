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

int[,] createAndFillMatr(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
         for (int j = 0; j < arr.GetLength(1); j++){
            arr[i, j] = Convert.ToInt32(new Random().Next(-100, 100)) / 10;
        }
    }
    return arr;
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
// void findSumCol(int[,] arr){
//     Console.WriteLine("Исходный массив ");
//     PrintArray(arr);

//     int sum = 0;
//     int minSum = Int32.MaxValue;
//     int minPos = 0;
//     for(int i = 0; i < arr.GetLength(0); i ++){
//         for(int j = 0; j < arr.GetLength(1); j ++){
//             sum += arr[i, j];
//         }   
//         if(sum < minSum){
//             minPos = i;
//             minSum = sum;
//         }
//         sum = 0;
//     }
//      Console.WriteLine($"Строка с наименьшей суммой {minPos + 1}");
// }

//Task 3
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

//Task 1
// int[,] arr = createAndFillMatr();
// sortLines(arr);

//Task 2
// int[,] arr = createAndFillMatr();
// findSumCol(arr);

//Task 3
Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
Console.WriteLine("Введите число строк 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());

int[,] firstMatr = new int[m, n];
createAndFillMatr(firstMatr);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMatr);

int[,] secondMatr = new int[n, p];
createAndFillMatr(secondMatr);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMatr);

int[,] resultMatr = new int[m, p];
MultiplyMatrix(firstMatr, secondMatr, resultMatr);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatr);