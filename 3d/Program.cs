//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int lenghtArray = 8;
int[] CreateArray(int lenghtArray)
{
    int[] rArray = new int[lenghtArray];
    Random r = new Random();
    for (int i = 0; i < rArray.Length; i++)
    {
        rArray[i] = r.Next(0, 99);
    }
    return rArray;
}

String GetArray(int[] array)
{
    string result = "";
    int i = 0;
    for (i = 0; i < array.Length-1; i++)
    {
       result += $"{array[i].ToString()}, ";
   }
   result += $"{array[i].ToString()}";
    return result;
}

Console.WriteLine($"[{GetArray(CreateArray(lenghtArray))}]");
