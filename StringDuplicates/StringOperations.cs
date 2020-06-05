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
            StringBuilder toJoin = new StringBuilder(string.Empty);
            for (int i = 0; i < sentence.Length; i++)
            {
                toJoin.Append(sentence[i]);
                if (count < toSkip.Length && sentence[i] != toSkip[count++])
                {
                    result.Append(toJoin);
                    toJoin = new StringBuilder(string.Empty);
                    count = 0;
                }

                if (count == toSkip.Length && toSkip.Length != 0)
                {
                    result.Append(" ");
                    toJoin = new StringBuilder(string.Empty);
                    count = 0;
                }
            }

            return result.Append(toJoin).ToString().Trim();
        }
    }
}