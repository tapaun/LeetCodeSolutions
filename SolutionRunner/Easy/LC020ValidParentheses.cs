using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.String, LeetCodeTag.Stack)]
public class LC020ValidParentheses {
    public bool IsValid(string s) {
        Stack<char> charStack = new();
        foreach(char c in s)
        {
            if(c == '(' || c == '{' || c == '[')
                charStack.Push(c);
            else
            {
                if(charStack.Count == 0) return false;
                char top = charStack.Pop();
                if((c == ')' && top != '(') ||
                   (c == '}' && top != '{') ||
                   (c == ']' && top != '['))
                    return false;
            }
        }
        return charStack.Count == 0;
    }
}

