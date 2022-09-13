
using System.Text.RegularExpressions;
using Xunit.Sdk;

namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        int sum = 0;
        if (numbers.Length > 0)
        {
            string pattern = @"([0-9]+)";
            Regex regex = new Regex(pattern);
            foreach (Match match in regex.Matches(numbers))
            {
                int val = int.Parse(match.Value);
                if(val <= 1000)
                {
                    sum += val;
                }
                
            }
        }

        return sum;
    }

}
