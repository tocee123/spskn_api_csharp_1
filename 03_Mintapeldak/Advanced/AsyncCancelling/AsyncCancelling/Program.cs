Console.WriteLine("Async cancelling in progress, to quit, press Ctrl+C");

var progress = SetupProgress();
var cancellationToken = SetupCancellationToken();

await Calculation(progress, cancellationToken);

static CancellationToken SetupCancellationToken()
{
    var cts = new CancellationTokenSource();
    Console.CancelKeyPress += (s, e) =>
    {
        Console.WriteLine("\nCanceling...");
        cts.Cancel();
        e.Cancel = true;
    };
    return cts.Token;
}

static IProgress<int> SetupProgress()
{
    var progress = new Progress<int>();
    progress.ProgressChanged += (_, i) => { Console.Write($"\r{i}%"); };
    return progress;
}

static async Task Calculation(IProgress<int> progress, CancellationToken token)
{
    for (int i = 0; i < 100; i++)
    {
        if (token.IsCancellationRequested)
        {
            break;
        }
        await Task.Delay(100);
        progress?.Report(i);
    }
}