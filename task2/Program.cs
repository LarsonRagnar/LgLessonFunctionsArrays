// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = GetArray(12, -9, 9);
//создание массива  
//3 параметра 1 размера массива size
//2 нижняя граница рандома 3 верхняя граница рандома
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;  // вернули массив на size заполненный числами
}


int[] InverseArray (int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        inputArray[i] *= (-1);
    }
    return inputArray;
}


Console.WriteLine($"Исходный массив[{String.Join(";", array)}]");
Console.WriteLine($"Перевернутый массив[{String.Join(";", InverseArray(array))}]");
// int sumPositive = 0;
// int sumNegative = 0;
// int size = array.Length;
// for (int i = 0; i < size; i++)
// {
//     if (array[i] > 0)
//     {
//         sumPositive += array[i];
//     }
//     else
//     {
//         sumNegative += array[i];
//     }
// }
// Console.WriteLine($"сумма положительных чисел {sumPositive} сумма отрицительных чисел {sumNegative}");