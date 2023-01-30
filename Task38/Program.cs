int [] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int GetNumber(int[] array)
{
    var max = array[0];
    var min = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        else if(array[i] < min)
            min = array[i];
    }
    count = max - min;
    return count;
}
int[] arr = InitArray(5);
PrintArray(arr);
int a = GetNumber(arr);
Console.WriteLine(a);