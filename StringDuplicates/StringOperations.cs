using System;
using System.Text;

namespace StringOperations
{
    public class StringOperations
    {
        public string RemoveDuplicates(char giveCharacter, string word)
        {
            if (string.IsNullOrEmpty(word) || word.Length < 2)
                return word;

            string duplicate = giveCharacter.ToString() + giveCharacter.ToString();

            while (word.Contains(duplicate))
            {
                word = word.Remove(word.IndexOf(duplicate), 1);
            }

            return word;
        }

        public string RemoveEndingCharacters(char giveCharacter, string word)
        {
            if (string.IsNullOrEmpty(word) || !word.EndsWith(giveCharacter))
                return word;

            while (word.EndsWith(giveCharacter))
            {
                word = word.Remove(word.LastIndexOf(giveCharacter));
            }

            return word;
        }

        public string ReplaceSubstring(string sentence, string toSkip)
        {
            int count = 0;
            StringBuilder result = new StringBuilder(string.Empty);
            StringBuilder buffer = new StringBuilder(string.Empty);

            for (int i = 0; i < sentence.Length; i++)
            {
                buffer.Append(sentence[i]);
                if (count < toSkip.Length && sentence[i] != toSkip[count++])
                {
                    SaveResultEmptyBuffer(ref buffer, ref result, ref count);
                }

                if (count == toSkip.Length && toSkip.Length != 0)
                {
                    buffer = new StringBuilder(" ");
                    SaveResultEmptyBuffer(ref buffer, ref result, ref count);
                }
            }

            return result.Append(buffer).ToString().Trim();
        }

        private void SaveResultEmptyBuffer(
            ref StringBuilder toAppend,
            ref StringBuilder result,
            ref int count)
        {
            result.Append(toAppend);
            toAppend = new StringBuilder(string.Empty);
            count = 0;
        }
    }
}