using TrainingTasks.Queue;

Printer printer = new();
while (true)
{
    var path = Console.ReadLine() ?? string.Empty;
    printer.AddDocument(path);
}