using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class NumberReplacerTests
{
    [Test]
    public void TestReplaceNumbers()
    {
        NumberReplacer replacer = new NumberReplacer();
        List<int> input1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        List<string> expectedOutput1 = new List<string> { "1", "2", "fizz", "muzz", "buzz", "fizz", "guzz", "muzz", "fizz", "buzz", "11", "fizz-muzz", "13", "guzz", "fizz-buzz" };

        List<string> actualOutput1 = replacer.ReplaceNumbers(input1);

        Assert.AreEqual(expectedOutput1, actualOutput1);
    }

}