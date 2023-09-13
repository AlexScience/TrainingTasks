ReverseArray(new[] { 1, 2, 3, 4, 5 });
ReverseArray(new[] { 1, 2, 3, 4 });
ReverseArray(Array.Empty<int>());

void ReverseArray(int[] inputArray)
{
    for (int a = 0; a < inputArray.Length / 2; a++)
    {
        var oldValue = inputArray[a];
        inputArray[a] = inputArray[inputArray.Length - 1 - a];
        inputArray[inputArray.Length - 1 - a] = oldValue;
    }

    Print(inputArray);
}

void Print(int[] array)
{
    foreach (var value in array)
    {
        Console.WriteLine(value);
    }

    Console.WriteLine("\n");
}