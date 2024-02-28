using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        NumberReplacer replacer = new NumberReplacer();
        List<int> input = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<string> output = replacer.ReplaceNumbers(input);

        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
    }
}

public class NumberReplacer
{
    public List<string> ReplaceNumbers(List<int> numbers)
    {
        return numbers.Select(n =>
        {
            if (n % 3 == 0 && n % 5 == 0 && n % 4 == 0 && n % 7 == 0)
            {
                return "good-boy-muzz-guzz";
            }
            else if (n % 3 == 0 && n % 5 == 0 && n % 4 == 0)
            {
                return "good-boy-muzz";
            }
            // добавление других комбинаций замен
            else if (n % 4 == 0 && n % 7 == 0)
            {
                return "muzz-guzz";
            }
            else if (n % 3 == 0 && n % 7 == 0 && n % 5 == 0)
            {
                return "good-boy-guzz-buzz";
            }
            else if (n % 3 == 0 && n % 5 == 0)
            {
                return "good-boy";
            }
            // переход к другим условиям и добавление новых замен
            else if (n % 3 == 0)
            {
                return "dog";
            }
            else if (n % 5 == 0)
            {
                return "cat";
            }
            else if (n % 7 == 0)
            {
                return "guzz";
            }
            else if (n % 4 == 0)
            {
                return "muzz";
            }
            else
            {
                return n.ToString();
            }
        }).ToList();
    }
}

