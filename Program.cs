// Программа, которая из имеющегося массива строк формирует массив строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры.

Console.Clear();

int count = 0;
string[] strArray = new string[count];

EnterStrArray();

string[] newStrArray = GenStrArray(strArray);

PrintArray(strArray);
Console.Write(" -> ");
PrintArray(newStrArray);


void EnterStrArray()
{
   string str;
   string[] strArray2;
   Console.WriteLine("Enter strings (End of input <ENTER>): ");
   do
   {
      str = Console.ReadLine() ?? "";
      if (str != "")
      {
         count++;
         strArray2 = new string[count];

         for (int i = 0; i < strArray2.Length - 1; i++)
            strArray2[i] = strArray[i];

         strArray2[count - 1] = str;
         strArray = strArray2;
      }
   } while (str != "");
}

void PrintArray(string[] inArray)
{
   Console.Write($"[ ");
   for (int i = 0; i < inArray.Length; i++)
   {
      Console.Write($"\"{inArray[i]}\" ");
   }
   Console.Write($"]");
}

string[] GenStrArray(string[] inArray)
{
   int size = 0;
   string[] result = new string[size];
   string[] variablyArray;

   for (int i = 0; i < inArray.Length; i++)
   {
      if (inArray[i].Length <= 3)
      {
         size++;
         variablyArray = new string[size];
         for (int j = 0; j < variablyArray.Length - 1; j++)
         {
            variablyArray[j] = result[j];
         }
         variablyArray[size - 1] = inArray[i];
         result = variablyArray;
      }
   }
   return result;
}

