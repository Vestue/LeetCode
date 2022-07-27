class Solution:
    def numIdenticalPairs(self, nums: List[int]) -> int:
        result = 0
        used = {}
        for i in nums:
            if i in used:
                result += used[i]
                used[i] += 1
            else:
                used[i] = 1
        return result