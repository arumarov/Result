int[] arrayA = new int[10];

void CreateArrayA (int[] arrayA)
{
    int countA = arrayA.Length;
    for (int i = 0; i < countA; i++)
    {
        arrayA[i] = new Random().Next(1,100);
    }
}

void PrintArrayA (int[] arrayA)
{
    int countA = arrayA.Length;
    for (int i = 0; i < countA; i++)
    {
        Console.Write($"{arrayA[i]} ");
    }
}

int FindLengthB (int[] arrayA)
{
    int countA = arrayA.Length;
    int lengthB = 0;
    for (int i = 0; i < countA; i++)
    {
        if (arrayA[i]%2 == 0) lengthB++;
    }
    return lengthB;
}

int[] arrayB = new int[FindLengthB(arrayA)];

void CreateArrayB (int[] arrayA, int[] arrayB)
{
    int countA = arrayA.Length;
    int countB = arrayB.Length;
    int j = 0;
        for (int i = 0; i < countA; i++)
    {
        if (arrayA[i]%2 == 0)
        { 
        arrayB[j] = arrayA[i];
        j++;
        }
    }
}

void PrintArrayB (int[] arrayB)
{
    int countB = arrayB.Length;
    for (int j = 0; j < countB; j++)
    {
        Console.Write($"{arrayB[j]} ");
    }
}

CreateArrayA(arrayA);
Console.Write("Заданный массив A: ");
PrintArrayA(arrayA);
FindLengthB(arrayA);
CreateArrayB(arrayA,arrayB);
Console.Write("\nМассив B: ");
PrintArrayB(arrayB);