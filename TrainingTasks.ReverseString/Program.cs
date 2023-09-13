using System.Text;
ReverseString("a d c");

void ReverseString(string inputString)
{
    StringBuilder stringBuilder = new StringBuilder();
    for (int i = inputString.Length - 1; i >= 0; i--)
    {
        stringBuilder.Append(inputString[i]);
    }

    Print(stringBuilder.ToString());
}

void Print(string str)
{
    Console.WriteLine($"{str}\n");
}