

var taskCompletionSource = new TaskCompletionSource<bool>();

var myThread = new Thread(() => 
{
    Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId} Started");
    Thread.Sleep(1000);
    taskCompletionSource.TrySetResult(true);
    Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId} Ended");
});
myThread.Start();

var test = taskCompletionSource.Task.Result;  // Dette er taskens resultat
Console.WriteLine($"Task complete {test}");



