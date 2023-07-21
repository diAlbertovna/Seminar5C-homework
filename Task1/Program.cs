//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int CountEven(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i++)
    {
        sum = sum + array[i];
        i +=1;
    }
    return sum;
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

int[] array = NewRandomArray(5,1,5);
Console.WriteLine($"[{string.Join(",", array)}] -> {CountEven(array)}");
