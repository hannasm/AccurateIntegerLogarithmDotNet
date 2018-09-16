# Versioning
This is version 1.0.0 of the accurate integer logarithm library

This package is available from nuget at: https://www.nuget.org/packages/AccurateIntegerLogarithm/1.0.0

The source for this release is available on github at: https://github.com/hannasm/AccurateIntegerLogarithmDotNet/releases/tag/1.0.0


# AccurateIntegerLogarithmDotNet
Accurate Integer Logarithm implements a version of the Math.Log() function (logarithms) designed exclusively for working with integers. Any input that would produce a fractional output normally, is instead truncated down to the next lowest integer. It does all of this while being significantly faster than the built-in logarithm function too!

# Motivation
Have you ever used, or wanted to use the Logarithm on an integer value. Did you notice that the built-in .NET math library only supports this for floating point double precision numbers? Did you also notice that between the conversion from integer to floating point, and flating point back to integer seemingly basic calculations can give drastically incorrect results.

I discovered this major inaccuracy with the following simple code:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Log {0}", (long)Math.Log(1000L, 10L));
    }
}
```

[See The Test Case Here](AccurateIntegerLogarithm.Tests/Motivation.cs)

The output being given by this code is 'Log 2', but the correct answer would be 'Log 3'. The same code performed on an int instead of long gives correct output. On different hardware with different floating point processors, this code might give the correct output. The fat is that there are inaccuracy bombs waiting to cause unexpected behavior in your program if this kind of behavior happens over even a single number in your input range.


# Usage

Initialize the acurate integer logarithm tool with the base of your choosing and start calling it:

```csharp
var base10 = new AccurateIntegerLogarithm.AccurateIntegerLogarithmTool(10);

var calc = base10.Log(1024); // calc == 3
```

There really isn't anything more to it than that.

# Performance
Some primitive but effective performance tests are present in the test suite. The debug build performs on par with the System.Math code, and the Release build seems to consistently perform on the order of about 4x better on my test machine.

# Under The Hood
The logarithm tool stores lookup tables, one for each base that is used / initialized by your program. You only pay for logarithm bases you care about, but once you initialize one it will use a tiny bit of memory for the life of your application. The lookup tables are cached internally so creating multiple instances with the same base does not incur extra memory usage or overhead.

The lookup tables are implemented as a binary search tree, a separate node  exists in the tree for each output and it's smallest corresponding input. To calculate log, look for the largest node in the tree that has a smaller input than the value you are calculating.

# Test Coverage
There is a fairly comprehensive set of tests covering all logarithms for base 2-10 in the LogarithmTests.cs project

There are also a few performance tests available, to do some basic comparisons to the System.Math.Log() function

# Release Notes

[For Release Notes See Here](AccurateIntegerLogarithm.ReleaseNotes.md)

