using System;
using System.Linq;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first.");
        }

        public int MaxConsecutiveUnequalChars(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 1;
                }
            }

            return maxCount;
        }

        public int MaxConsecutiveLatinLetters(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int maxCount = 0;
            int currentCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]) && input[i] == input[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 1;
                }
            }

            return maxCount;
        }

        public int MaxConsecutiveDigits(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int maxCount = 0;
            int currentCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) && input[i] == input[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 1;
                }
            }

            return maxCount;
        }
    }
}