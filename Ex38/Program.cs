// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = rand.Next(-10,100);

    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int DifferenceMinMax(int[] array)
{
    int max = array[0];
    int min = array[0];
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    res = max - min;
    return res;
}

System.Console.WriteLine("Enter array length");
int length = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[length];
FillArray(mas);
PrintArray(mas);
System.Console.WriteLine();
int result = DifferenceMinMax(mas);
System.Console.WriteLine(result);