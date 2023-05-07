// Time complexity: O(n) and Space complexity: O(1)

string input = Console.ReadLine();

Console.WriteLine(IsPalindrome(input));

bool IsPalindrome(string str)
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - (i + 1)])
        {
            return false;
        }
    }
    return true;
}
