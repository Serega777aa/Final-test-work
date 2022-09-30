int GetAmountValues(string[] array, int number)
{
    int amount = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= number)
        {
            amount++;
        }
    }  
    return amount;  
}

void FillNewArray(string[] array, string[] newArray, int number)
{
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= number)
        {
            newArray[j] = array[i];
            j++;
        }
    }
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}

string[] arr = new string[] {"1234", "1567", "-2", "computer science", "kdkfk", "0394", "kjh", "jj"};
string[] newArr = new string[GetAmountValues(arr, 3)];

FillNewArray(arr, newArr, 3);
PrintArray(arr);
Console.WriteLine();
PrintArray(newArr);

