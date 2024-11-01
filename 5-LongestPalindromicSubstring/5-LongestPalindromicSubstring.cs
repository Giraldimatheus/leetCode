public class Solution {
    public string LongestPalindrome(string s)
{
    if (s.Length < 1)
    {
        return s;
    }

    string longest = "";

    for (int i = 0; i < s.Length; i++)
    {
        // Checa por palíndromos de comprimento ímpar
        string oddPalindrome = ExpandAroundCenter(s, i, i);
        if (oddPalindrome.Length > longest.Length)
        {
            longest = oddPalindrome;
        }

        // Checa por palíndromos de comprimento par
        string evenPalindrome = ExpandAroundCenter(s, i, i + 1);
        if (evenPalindrome.Length > longest.Length)
        {
            longest = evenPalindrome;
        }
    }

    return longest;
}

private string ExpandAroundCenter(string s, int left, int right)
{
    while (left >= 0 && right < s.Length && s[left] == s[right])
    {
        left--;
        right++;
    }
    return s.Substring(left + 1, right - left - 1);
}
}