public class Solution
{
    public bool IsPalindrome(string s)
    {

        //two pointer patterni kullanýlacak
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            //alfanumerik olmayan karakter varsa sag veya sola kaydýr
            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }

            // lowercase yap tüm harfleri
            char leftChar = char.ToLower(s[left]);
            char rightChar = char.ToLower(s[right]);

            // karakter farklýysa FALSE aynýysa TRUE döner
            if (leftChar != rightChar)
            {
                return false;
            }

            left++;
            right--;




        }

        return true;

    }
}