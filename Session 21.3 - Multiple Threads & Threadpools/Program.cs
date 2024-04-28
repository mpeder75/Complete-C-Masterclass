// Her laves en enmum der oprette 100 threads, og de køres concurrent
// Dvs. de vil hver især slutte på forskellige tidspunkter

Enumerable.Range(0, 100).ToList().ForEach(x =>
{
    new Thread(() =>
    {
        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
        Thread.Sleep(1000);
        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
    }).Start();
});


//! Threadpools sikre at der KUN oprettes de threads der er nødverndigt
//! Thread pools genbruger threads, da sletning af en thread tager resourcer
//! Dvs. når der pludseligt er behov for mange threads, vil threadpool opjustere antallet
Enumerable.Range(0, 100).ToList().ForEach(x =>
{
    ThreadPool.QueueUserWorkItem((f) =>
    {
        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
        Thread.Sleep(1000);
        Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
    });
});
