//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreatRandomArray (int min, int max)
{
  Console.WriteLine("Введите число элементов массива: ");
  int size = Convert.ToInt32(Console.ReadLine());

 int[] array= new int[size];
for( int i=0; i<size; i++)
{
    array[i]=new Random().Next(min, max+1);
}
return array;
}

void ShowArray(int[] array)
{
for(int i=0; i<array.Length; i++)
{
    Console.Write(array[i]+ ", ");
}
}

int[] myArray = CreatRandomArray(-100,100);
ShowArray(myArray);


int minPos= myArray[0];
for(int i= 0; i<myArray.Length; i++)

{if (myArray[i]<minPos) minPos=myArray[i];}



int maxPos= myArray[0];
for(int i= 0; i<myArray.Length; i++)

{if (myArray[i]>maxPos) maxPos=myArray[i];}

int S=maxPos-minPos;
  Console.WriteLine("Разница между максимальным и минимальным элементами массива равна: "+S);


