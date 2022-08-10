public class Solution {
    public IList<string> FizzBuzz(int n) {
        var result = new List<string>();
        
        for (int i = 1; i <= n; i++) {
            string curr = "";
            if (i % 3 == 0) curr += "Fizz";
            if (i % 5 == 0) curr += "Buzz";
            
            if (String.IsNullOrEmpty(curr)) result.Add(i.ToString());
            else result.Add(curr);
        }
        
        return result;
    }
}