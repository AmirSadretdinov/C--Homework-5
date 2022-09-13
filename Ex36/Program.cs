// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = rnd.Next(-10,100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int SumUnevenElem(int[] array) 
{   
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if ( !(i%2 == 0)){
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.WriteLine("Введите длину массива");
int input = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[input];
FillArray(mas);
PrintArray(mas);
Console.WriteLine();
int res = SumUnevenElem(mas);
Console.WriteLine($"Сумма нечетных элементов массива = {res}");

