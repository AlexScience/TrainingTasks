namespace TrainingTasks.Stack;

public class Word
{
    private readonly Stack<string> _stack = new();
    private readonly Stack<string> _cache = new();

    public void AddText(string text)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException("Пустая строка");

            HandleCommand(text);
            Print();
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Пустая строка не допустима введите любое слово");
        }
    }

    private void Undo()
    {
        if (_stack.TryPop(out var message))
        {
            _cache.Push(message);
        }
    }

    private void Redo()
    {
        if (_cache.TryPop(out var message))
        {
            _stack.Push(message);
        }
    }

    private void Print()
    {
        Console.WriteLine(string.Join(' ', _stack));
    }

    private void HandleCommand(string message)
    {
        if (message.StartsWith("-r") || message.StartsWith("-R"))
        {
            Redo();
        }
        else if (message.StartsWith("-u") || message.StartsWith("-U"))
        {
            Undo();
        }
        else
        {
            AddTextInStack(message);
        }
    }

    private void AddTextInStack(string text)
    {
        _stack.Push(text);
    }
}