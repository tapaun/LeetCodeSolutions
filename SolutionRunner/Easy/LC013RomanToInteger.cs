using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.HashTable, LeetCodeTag.Math, LeetCodeTag.String)]
public class LC013RomanToInteger {
    private static int NextChar(char c, char a1, char a2) {
        return (c == a1 || c == a2) ? -1 : 1;
    }
    public int RomanToInt(string s) {
        int result = 0;
        for(int i = 0;i<s.Length;i++)
        {
            char nextChar = (i+1<s.Length) ? s[i+1] : '\0';
            switch (s[i], nextChar) {
                case ('M', _): result += 1000; break;
                case ('D', _): result += 500; break;
                case ('C', 'M') or ('C', 'D'): result -= 100; break;
                case ('C', _): result += 100; break;
                case ('L', _): result += 50; break;
                case ('X', 'C') or ('X', 'L'): result -= 10; break;
                case ('X', _): result += 10; break;
                case ('V', _): result += 5; break;
                case ('I', 'X') or ('I', 'V'): result -= 1; break;
                case ('I', _): result += 1; break;
            }
        }
        return result;
    }
}

