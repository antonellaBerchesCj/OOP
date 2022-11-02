
public static class AsyncAwait
{
    // NOTE: Once you go async, all of your callers SHOULD be async, since efforts
    // to be async amount to nothing unless the entire callstack is async.
    // In many cases, being partially async can be worse than being entirely
    // synchronous. Therefore it is best to go all in, and make everything async at once

    // ASYNC VOID
    // Use of async void in ASP.NET Core applications is ALWAYS bad
    // Async void methods will crash the process if an exception is thrown.
    // Typically, it's used when developers are trying to implement fire and forget patterns triggered by a controller action
    // Async void methods can't be tracked and therefore unhandled exceptions can result in application crashes.

    // public async void DoSomething() --> BAD !! (crash if unhandled exceptions)
    // public async Task DoSomething() --> GOOD !! (better since unhandled exceptions trigger the TaskScheduler.UnobservedTaskException)


    // DoSomethingAsync1: not ok, because Task.Result blocks the current thread
    // to wait to the result. 
    public static int DoSomethingAsync1() // output: 2
    {
        var result = CallDependencyAsync().Result;
        Console.WriteLine(result + 1);
        return result + 1;
    }

    public static async Task<int> DoSomethingAsync() // output: 2
    {
        var result = await CallDependencyAsync();
        Console.WriteLine(result + 1);
        return result + 1;
    }

    private static async Task<int> CallDependencyAsync()
    {
        await Task.Delay(1000);
        return 1;
    }
}