using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    public static List<string> RegexFunction(string str) 
    {
        var regular = new Regex(@"([\S]*)(z)(\S){3}(z)([\S]*)");
        MatchCollection matches = regular.Matches(str);
        GroupCollection group;
        var result = new List<string>();
        foreach (Match match in matches)
        {
            group = match.Groups;
            result.Add(group[0].Value);
        }
        return result;
    }

    static void Main()
    {
        var a = RegexFunction("zebra zigzag @#$Az#aaz zeal Aez$alz");
        for (int i = 0; i < a.Count; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}