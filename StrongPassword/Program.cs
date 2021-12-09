using System.Linq;
using System;

class Result
{
    //public static int MinimumNumber(int n, string password)
    //{
    //    var numbers = new Regex(@"[0-9]+");
    //    var upper_case = new Regex(@"[A-Z]+");
    //    var lower_case = new Regex(@"[a-z]+");
    //    var special_characters = new Regex(@"[!@#$%^&*()-+]");
    //    var minChars = new Regex(@".{6,100}");
    //    int cnt = 0;
    //    if (numbers.IsMatch(password))
    //    {
    //        cnt++;
    //    }
    //    if (upper_case.IsMatch(password))
    //    {
    //        cnt++;
    //    }
    //    if (lower_case.IsMatch(password))
    //    {
    //        cnt++;
    //    }
    //    if (special_characters.IsMatch(password))
    //    {
    //        cnt++;
    //    }

    //    if (n - cnt < 6)
    //    return 6 - cnt;
    //else
    //    return 4 - cnt;
    //}

    public static int MinimumNumber2(int n, string password)
    {
        int cnt = 0;
        string numbers = "0123456789";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string special_characters = "!@#$%^&*()-+";

        char[] pass = password.ToCharArray();

        foreach (var item in pass.Distinct())
        {
            if (numbers.Contains(item))
            {
                cnt++;
                break;
            }
        }
        foreach (var item in pass.Distinct())
        {
            if (upper_case.Contains(item))
            {
                cnt++;
                break;
            }
        }
        foreach (var item in pass.Distinct())
        {
            if (lower_case.Contains(item))
            {
                cnt++;
                break;
            }
        }
        foreach (var item in pass.Distinct())
        {
            if (special_characters.Contains(item))
            {
                cnt++;
                break;
            }
        }
        if (n - cnt < 6)
            return 6 - cnt;
        else
            return 4 - cnt;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        //int answer = Result.MinimumNumber(n, password);
        int answer = Result.MinimumNumber2(n, password);

        Console.WriteLine(answer);
        Console.ReadKey();
    }
}

