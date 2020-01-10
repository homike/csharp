using System;
using System.Collections.Generic;

namespace CSharp6
{
class CSharp6Sample
{
    public void Run()
    {
        this.indexAndrangeTest();
    }

    private void nameofTest()
    {
        Console.WriteLine(nameof(System.String));
        int j = 5;
        Console.WriteLine(nameof(j));
        List<string> names = new List<string>();
        Console.WriteLine(nameof(names));
    }

    private void newTest()
    {
        var messages = new Dictionary<int, string>
        {
            [404] = "Page not Found",
                    [302] = "Page moved, but left a forwarding address.",
                            [500] = "The web server can't come out to play today."
        };

        Console.WriteLine(messages[302]);
    }

    private void indexAndrangeTest()
    {
        string[] words = new string[]
        {
            // index from start    index from end
            "The",      // 0                   ^9
            "quick",    // 1                   ^8
            "brown",    // 2                   ^7
            "fox",      // 3                   ^6
            "jumped",   // 4                   ^5
            "over",     // 5                   ^4
            "the",      // 6                   ^3
            "lazy",     // 7                   ^2
            "dog"       // 8                   ^1
        };              // 9 (or words.Length) ^0

        Console.WriteLine($"The last word is {words[^1]}{words[^1]}");

        string[] quickBrownFox = words[1.. ^ 0];
        foreach (var word in quickBrownFox)
            Console.Write($"< {word} >");

        Console.WriteLine();
    }
}

}
