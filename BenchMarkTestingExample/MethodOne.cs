using System;
using System.Collections;
using System.Collections.Immutable;
using System.Data;
using Bogus;
using System.Diagnostics;
using System.Threading.Tasks.Sources;
public class MethodOne
{
    public static void Main(String[] args)
    {
        var randomAlphabeticalLetters = new Faker().Random.AlphaNumeric(1000).ToCharArray();

        Console.WriteLine("Print 1000 Random Alphabetical letters");

        var Stopwatch = new Stopwatch();
        Stopwatch.Restart();
        var result = new List<char>(randomAlphabeticalLetters);
        result.Sort();
        //First Method
        Stopwatch.Stop();
        Console.WriteLine($"Time Taken By LINQ Query Method : {Stopwatch.ElapsedTicks} ticks");
        Console.WriteLine($"Time taken by LiNQ method : {Stopwatch.ElapsedMilliseconds} ms");
        Console.ReadLine();
        //Second Method
        Stopwatch.Start();
        Array.Sort(randomAlphabeticalLetters);

        Stopwatch.Stop();
        Console.WriteLine($"Time taken by array.sort method : {Stopwatch.ElapsedTicks} ticks");
        Console.WriteLine($"Time taken by array.sort method : {Stopwatch.ElapsedMilliseconds} ms");

    }
}