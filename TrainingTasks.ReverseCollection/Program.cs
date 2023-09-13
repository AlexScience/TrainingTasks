Reverse(new[] { 1, 2, 3, 4 });
Reverse("Hello".ToCharArray());

void Reverse<T>(T[] inputArray)
{
    for (int a = 0; a < inputArray.Length / 2; a++)
    {
        var oldValue = inputArray[a];
        inputArray[a] = inputArray[inputArray.Length - 1 - a];
        inputArray[inputArray.Length - 1 - a] = oldValue;
    }

    Print(inputArray);
}

void Print<T>(T[] array)
{
    foreach (var value in array)
    {
        Console.WriteLine(value);
    }

    Console.WriteLine("\n");
}