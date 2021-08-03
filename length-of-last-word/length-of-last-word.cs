public class Solution {
    public int LengthOfLastWord(string s) 
    {
        string Words = s.TrimEnd(' ');
        int Letters = 0;
        for (int i = Words.Length - 1; i >= 0; i--)
        {
            if (Words[i] == ' ')
            {
                break;
            }
            Letters++;
        }
        return Letters;
    }
}
