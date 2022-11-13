// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
int[] CreateRandomArray(int min, int max)
{
    Console.WriteLine("Введите число элементов массива ");
    int size= Convert.ToInt32(Console.ReadLine());
int[] RandomArray = new int[size];
for (int i = 0; i < size; i++)
{
RandomArray[i] = new Random().Next(min, max + 1);
}
return RandomArray;
}

void ShowArray( int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i]+ ", ");
    }
    Console.WriteLine();
}
int[] myArray = CreateRandomArray(-100,100);
ShowArray(myArray);

int sum_i_neg = 0;
for (int i=0; i<myArray.Length; i++)
{
    if (i%2==0) 
    sum_i_neg+=myArray[i];
}
 Console.WriteLine("Сумма элементов стоящих на нечетных позициях равна: " + sum_i_neg);