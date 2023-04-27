Console.Clear();

Start();

void Start()
{
  string[] arrayFirst = GetFirstArray();
  PrintArray(arrayFirst);
  System.Console.WriteLine();
  string[] arrFinal = GetNewArray(arrayFirst);
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
  string[] newAr = new string[array.Length];
  int count = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
      newAr[i] = array[i];    
  }

  return newAr;
}
