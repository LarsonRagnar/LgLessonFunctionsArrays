// Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.
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
Console.WriteLine($"[{String.Join(";", array)}]");


int sumPositive = 0;
int sumNegative = 0;
int size = array.Length;
for (int i = 0; i < size; i++)
{
    if (array[i] > 0)
    {
        sumPositive += array[i];
    }
    else
    {
        sumNegative += array[i];
    }
}
Console.WriteLine($"сумма положительных чисел {sumPositive} сумма отрицительных чисел {sumNegative}");
