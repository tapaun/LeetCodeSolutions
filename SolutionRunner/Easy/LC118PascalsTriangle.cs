using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Array, LeetCodeTag.DynamicProgramming)]
public class LC118PascalsTriangle {
    public IList<IList<int>> Generate(int numRows) {
        if(numRows == 0) return new List<IList<int>>();
        var result = new List<IList<int>>();
        result.Add(new List<int>{1});
        for (int i = 1; i < numRows; i++) {
            var row = new List<int>();
            row.Add(1);
            for (int j = 1; j < i; j++) {
                row.Add(result[i - 1][j - 1] + result[i - 1][j]);
            }
            row.Add(1);
            result.Add(row);
        }
        return result;
    }
}

