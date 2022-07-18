public class Solution {
    public int MostWordsFound(string[] sentences) {
        int maxWords = 0, currWords;
        foreach (var sentence in sentences)
        {
            currWords = 0;
            foreach(var word in sentence.Split())
            {
                currWords++;
            }
            if (currWords > maxWords) maxWords = currWords;
        }
        return maxWords;
    }
}