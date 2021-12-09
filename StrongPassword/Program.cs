using System.Linq;
using System;
using System.Text.RegularExpressions;

class Result
{
    public static int MinimumNumber1(int n, string password)
    {
        int count = 0;
        int minLength = 6;
        string numbers = "0123456789";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string special_characters = "!@#$%^&*()-+";

        char[] pass = password.ToCharArray();

        foreach (var item in pass.Distinct())
        {
            if (numbers.Contains(item))
            {
                count++;
                break;
            }
        }
        foreach (var item in pass.Distinct())
        {
            if (upper_case.Contains(item))
            {
                count++;
                break;
            }
        }
        foreach (var item in pass.Distinct())
        {
            if (lower_case.Contains(item))
            {
                count++;
                break;
            }
        }
        foreach (var item in pass.Distinct())
        {
            if (special_characters.Contains(item))
            {
                count++;
                break;
            }
        }
        if (n - count < minLength)
            return minLength - count;
        else
            return 4 - count;
    }
    public static int MinimumNumber2(int n, string password)
    {
        int count = 0;
        int minLength = 6;
        var numbers = new Regex(@"[0-9]+");
        var upper_case = new Regex(@"[A-Z]+");
        var lower_case = new Regex(@"[a-z]+");
        var special_characters = new Regex(@"[!@#$%^&*()-+]");

        if (numbers.IsMatch(password))
        {
            count++;
        }
        if (upper_case.IsMatch(password))
        {
            count++;
        }
        if (lower_case.IsMatch(password))
        {
            count++;
        }
        if (special_characters.IsMatch(password))
        {
            count++;
        }

        if (n - count < minLength)
            return minLength - count;
        else
            return 4 - count;
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer1 = Result.MinimumNumber1(n, password);
        Console.WriteLine(answer1);
        int answer2 = Result.MinimumNumber2(n, password);
        Console.WriteLine(answer2);
        
        Console.ReadKey();
    }
}

