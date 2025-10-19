using SolutionRunner.LCAttributes;

namespace SolutionRunner.Easy;

[LeetCodeTags(LeetCodeTag.Math, LeetCodeTag.String)]
public class LC168ExcelSheetColumnTitle {
    public string ConvertToTitle(int columnNumber) {
        string result = "";
        while (columnNumber > 0) {
            columnNumber--;
            int remainder = columnNumber % 26;
            result = (char)(remainder + 'A') + result;
            columnNumber /= 26;
        }
        return result;
    }
}

