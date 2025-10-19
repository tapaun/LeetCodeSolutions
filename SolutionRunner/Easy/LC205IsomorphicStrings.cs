using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.HashTable, LeetCodeTag.String)]
public class LC205IsomorphicStrings {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;
        
        Dictionary<char, char> mapST = new Dictionary<char, char>();
        Dictionary<char, char> mapTS = new Dictionary<char, char>();
        
        for (int i = 0; i < s.Length; i++) {
            char charS = s[i];
            char charT = t[i];
            
            if (!mapST.ContainsKey(charS)) {
                mapST[charS] = charT;
            } else if (mapST[charS] != charT) {
                return false;
            }
            
            if (!mapTS.ContainsKey(charT)) {
                mapTS[charT] = charS;
            } else if (mapTS[charT] != charS) {
                return false;
            }
        }
        return true;
    }
}

