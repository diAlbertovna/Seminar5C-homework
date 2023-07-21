// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int CountEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count+=1;
    }
    return count;
}

int [] NewRandomArray(int size, int beginValue, int endValue)
{
    int[]array = new int[size];
    for (int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(beginValue,endValue);
    }
    return array;
}

int[] array = NewRandomArray(5,100,1000);
Console.WriteLine($"[{string.Join(",", array)}] -> {CountEven(array)}");
