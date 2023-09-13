using TrainingTasks.Stack;

Word word = new();
while (true)
{
    var text = Console.ReadLine() ?? string.Empty;
    word.AddText(text);
}