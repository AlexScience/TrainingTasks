using System.Timers;
using Timer = System.Timers.Timer;

namespace TrainingTasks.Queue;

public class Printer : IDisposable
{
    private readonly Queue<string> _queue = new();
    private readonly Timer _timer = new();

    public Printer()
    {
        _timer.Elapsed += PrintQueue;
        _timer.Interval = 3000;
        _timer.Enabled = true;
    }

    public void AddDocument(string pathToFile)
    {
        _queue.Enqueue(pathToFile);
        Console.WriteLine($"Added document {pathToFile}");
    }

    private void PrintDocument(string activeDocument)
    {
        Console.WriteLine($"Printing {activeDocument}");
    }

    private void PrintQueue(object? state, ElapsedEventArgs args)
    {
        while (_queue.TryPeek(out var _))
        {
            var activeDocument = _queue.Dequeue();
            PrintDocument(activeDocument);
        }
    }

    public void Dispose()
    {
        _timer.Dispose();
    }
}