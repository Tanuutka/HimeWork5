// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая 
//покажет количество чётных чисел в массиве.

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
int[] myArray = CreateRandomArray(100,999);
ShowArray(myArray);

int sum_pos=0;
for (int i=0; i < myArray.Length; i++)
{
    if (myArray[i]%2==0)
     sum_pos+=1;
}

Console.WriteLine("Количество четных чисел равно "+ sum_pos);