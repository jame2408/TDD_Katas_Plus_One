namespace TDD_Katas_Plus_One
{
    class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] += 1;
                if (digits[i] <= 9)
                {
                    return digits;
                }
                digits[i] = 0;
            }

            var ints = new int[digits.Length + 1];
            ints[0] = 1;

            return ints;
        }
    }
}