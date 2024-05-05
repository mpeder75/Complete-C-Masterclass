
Console.WriteLine("Main thread started");

Thread thread1 = new Thread(Thread1Function);
Thread thread2 = new Thread(Thread2Function);
thread1.Start();
thread2.Start();

//! Join gør at Main thread blokere(venter) indtil thread1 er færdig med at køre sin kode
thread1.Join();
Console.WriteLine("Thread1 joinet");
thread2.Join();
Console.WriteLine("thread2 joinet");


//! isAliv returnere true hvis den er started men endnu ikke færdig
if (thread1.IsAlive)
{
    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is alive");
} else
{
    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} was completed");
}

Console.WriteLine("Main thread ended");

void Thread1Function()
{   
    Console.WriteLine($"Thread1function started");
    Thread.Sleep(9000);
}

void Thread2Function()
{
    Console.WriteLine($"Thread2function started");
}

/* 
Måden der compiles:

Main Thread:
1.  The main thread starts by printing “Main thread started.”
    It then creates two new threads (thread1 and thread2) and starts them concurrently.
2.  Thread1 (thread1):
    Thread1Function is executed on thread1.
    Inside Thread1Function, it prints “Thread1function started” and then sleeps for 3000 milliseconds (3 seconds) using Thread.Sleep(3000).
3.  Thread2 (thread2):
    Thread2Function is executed on thread2.
    Inside Thread2Function, it prints “Thread2function started.”
4.  Main Thread (Continuation):
    The main thread waits for thread1 to complete using thread1.Join().
    After thread1 finishes (waits for 3 seconds), it prints “Thread1 joinet.”
    The main thread then waits for thread2 to complete using thread2.Join().
    After thread2 finishes (immediately), it prints “thread2 joinet.”
    Finally, the main thread prints “Main thread ended.”  
*/