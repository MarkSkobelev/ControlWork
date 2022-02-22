/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

void PrintArray(string[] array)
{
  Console.Write("["); 
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"\"{array[i]}\"");
    if (i != array.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
}

int StringsCount(string[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      count++;
    }
  }
  return count;
}

string[] SecondArrayCreate(string[] arr1, int arr2)
{
  string[] secondArray = new string[arr2];
  int j = 0;
  for (int i = 0; i < arr1.Length; i++)
  {
    if (arr1[i].Length <= 3)
    {
      secondArray[j] = arr1[i];
      j++; 
    }
  }
  return secondArray;
}

string[] firstArray = { "Hel", "world", "lo", "Wo", "5849", "rld", " !" };
PrintArray(firstArray);
int secondArraySize = StringsCount(firstArray); 
string[] secondArray = SecondArrayCreate(firstArray, secondArraySize); 
Console.Write(" --> ");
PrintArray(secondArray);
Console.WriteLine();