Console.Clear();

Start();

void Start()
{
  string[] arrayFirst = GetFirstArray();
  System.Console.WriteLine();
  PrintArray(arrayFirst);
  System.Console.WriteLine();
  string[] arrFinal = GetNewArray(arrayFirst);
  System.Console.WriteLine("New array with elements of the first array  with length <= 3 ");
  PrintArray(arrFinal);
}


string[] GetFirstArray() // получаем стартовый массив 
{
  string[] array = Console.ReadLine()!.Split(' ').ToArray();
  return array;
}

void PrintArray(string[] array)//распечатываем массив 
{
  System.Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
  {
    System.Console.Write($"{array[i]}, ");
  }
  System.Console.Write($"{array[array.Length - 1]}");
  System.Console.WriteLine("]");
}

string[] GetNewArray(string[] array) // получание нового массива 
{
  int count = 0;
  for (int i = 0; i < array.Length; i++) // определяем длину нового массива 
  {
    if (array[i].Length <= 3) count++;
  }

  string[] newAr = new string[count];
  int j = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      newAr[j] = array[i];
      j++;
    }
  }
  return newAr;
}
