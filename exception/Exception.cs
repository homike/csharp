using System;

namespace ExceptionTest
{
class ExceptionSample
{
    public void Run()
    {
        try
        {
            string s = null;
            Console.WriteLine(s.Length);
        }
        catch (Exception e) when (LogException(e))
        {
        }
        Console.WriteLine("Exception must have been handled");
    }

    private static bool LogException(Exception e)
    {
        Console.WriteLine($"Exception Caugt {e.GetType()}");
        Console.WriteLine($"Message {e.Message}");
        return true;
    }
}
}
