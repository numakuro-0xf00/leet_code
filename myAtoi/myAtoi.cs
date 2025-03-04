public class Solution {
    public int MyAtoi(string s) {
        int maxInt = int.MaxValue;
        int minInt = int.MinValue;

        int i = 0;
        int n = s.Count();
        int sign = 1;
        int result = 0;

        // Step 1: Skip leading whitespace
        while (i < n && s[i] == ' ') i++;

        // Step 2: Check for optional sign
        if (i < n && (s[i] == '-' || s[i] == '+')) {
            sign = (s[i] == '-') ? -1 : 1;
            i++;
        }

        // Step 3: Convert digits to integer
        while (i < n && Char.IsDigit(s[i])) {
            int digit = s[i] - '0';
            // Check for overflow
            if (result > (maxInt - digit) / 10) {
                return sign == 1 ? maxInt : minInt;
            }
            result = result * 10 + digit;
            i++;
        }
        
        return result * sign;
    }
}
