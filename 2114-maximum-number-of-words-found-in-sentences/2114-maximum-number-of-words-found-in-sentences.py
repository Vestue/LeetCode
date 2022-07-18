class Solution:
    def mostWordsFound(self, sentences: List[str]) -> int:
        maxWords = 0;
        for sentence in sentences:
            currWords = len(sentence.split())
            if (currWords > maxWords): 
                maxWords = currWords
        return maxWords