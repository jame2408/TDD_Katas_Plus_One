namespace TDD_Katas_Plus_One
{
    class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            digits[digits.Length - 1] += 1;
            return digits;
        }
    }
}