// Написать программу, которая из имеющегося массива
// строк формирует массив из строк, длина которых меньше или равна 3 символа.

string [] inputArray = new string[4] {"rggtg", "tgukuoil", "pol", "dg"};
string [] outputArray = new string[inputArray.Length];
int indexOut=0;
for (int indexIn = 0; indexIn < inputArray.Length; indexIn++)
{
    if (inputArray[indexIn].Length<=3)
    {
        outputArray[indexOut]=inputArray[indexIn];
        indexOut=indexOut+1;
    }
}


void PrintArray(string[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]}");
        if (i<size-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}



PrintArray (outputArray, indexOut);