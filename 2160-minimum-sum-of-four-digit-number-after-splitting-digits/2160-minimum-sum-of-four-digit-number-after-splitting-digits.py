class Solution:
    def minimumSum(self, num: int) -> int:
        result = sorted(str(num))
        return int(result[0]) * 10 + int(result[1]) * 10 + int(result[2]) + int(result[3])