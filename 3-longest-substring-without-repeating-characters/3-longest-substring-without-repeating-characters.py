class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        used = [-1] * 128
        result = 0
        left = 0
        lastChar = '0'
        
        for right in range(len(s)):
            if used[ord(s[right])] != -1:
                left = max(left, used[ord(s[right])] + 1)
                if lastChar == s[right]:
                    used = [-1] * 128
            used[ord(s[right])] = right
            result = max(result, right - left + 1)
            lastChar = s[right]
        return result