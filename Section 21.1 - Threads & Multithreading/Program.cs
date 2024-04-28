//! Process er et større program der køre uafhængigt, og i denne process har den flere threads, der hver især køre små underprogrammer
//! Mange threads kan derfor håndtere mange forskellige underprogrammer på en gang, kaldet concurrency 

//# Man splitter altså en Process memory op i mindre bidder, og uddeler denne memory til threads der derefter kan køre deres underprogram

/*
// Eksempel: Her brugges Main thread bruges til at opsætte sleep efter hver linje
// Dette er køres sekventielt, og er IKKE multithreading
Console.WriteLine("Hello world 1");
Thread.Sleep(1500); 
Console.WriteLine("Hello world 2");
Thread.Sleep(1500);
Console.WriteLine("Hello world 3");
*/

//! Multithreading: Her skabes threads, som startes med Start()
// De vil ikke køre sekventielt, da det er OS der beslutter hvilken Thread der køres først.
// Dvs threads køre deres kode på samme tid

new Thread(() => 
{
    Thread.Sleep(1000);
    Console.WriteLine("Thread 1");
}).Start();

new Thread(() =>
{
    Thread.Sleep(1000);
    Console.WriteLine("Thread 2");
}).Start();

new Thread(() =>
{
    Thread.Sleep(1000);
    Console.WriteLine("Thread 3");
}).Start();

new Thread(() =>
{
    Thread.Sleep(1000);
    Console.WriteLine("Thread 4");
}).Start();



