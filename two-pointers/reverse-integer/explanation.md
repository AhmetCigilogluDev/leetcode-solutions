Reverse Integer

Approach: Math / Digit Manipulation

Algorithm

Initialize a variable reversed = 0

While x is not equal to 0:

Extract the last digit using x % 10

Remove the last digit from x using x /= 10

Before updating reversed, check for overflow:

If reversed exceeds 32-bit integer limits, return 0

Append the digit to reversed:

reversed = reversed * 10 + digit

Return reversed