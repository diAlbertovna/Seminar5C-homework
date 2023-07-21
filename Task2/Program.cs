// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

double[] NewRandomDoubleArray(int size)
{
  double[] array = new double[size];
  Random random = new Random();
  for (int i = 0; i < size; i++)
  {
    array[i] = Math.Round((random.NextDouble() * 100), 2); // Генерация случайного числа от 0 до 99,.. с двумя знаками после запятой.
  }
  return array;
}

(double min, double max, double dif) MinMaxDifFind(double[] array)
{
  double min = array[0];
  double max = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if (array[i] < min)
    {
      min = array[i];
    }
    else if (array[i] > max)
    {
      max = array[i];
    }
  }
  double dif =  Math.Round((max - min), 2);
  return (min, max, dif);
}

double[] array = NewRandomDoubleArray(5); // Размер зададим 5. Как в образце вывода результата в решении.
var result = MinMaxDifFind(array); // Переменная result служит для сохранения результата вывода функции MinMaxDifFind. Нам с ним еще работать. 
Console.WriteLine("[" + string.Join(", ", array) + "]" + " => " + result.max + " - " + result.min + " = " + result.dif);