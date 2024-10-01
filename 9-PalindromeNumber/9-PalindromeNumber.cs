public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
        {
            return false;
        }

        string str = x.ToString();
        int length = str.Length;

        // Usado o length / 2 para evitar comparações desnecessárias.
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}