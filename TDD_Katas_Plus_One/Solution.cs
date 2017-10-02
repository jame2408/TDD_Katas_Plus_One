namespace TDD_Katas_Plus_One
{
    class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i] += 1;
                    return digits;
                }
                digits[i] = 0;
            }

            var newdigits = new int[digits.Length + 1];
            newdigits[0] = 1;

            return newdigits;
        }
    }
}