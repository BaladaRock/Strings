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
                for (int i = 1; i < word.Length; i++)
                {
                    if (word[i] == word[i - 1] && word[i] == giveCharacter)
                    {
                        word = word.Remove(i, 1);
                    }
                }
            }

            return word;
        }

        public string RemoveEndingCharacters(char giveCharacter, string word)
        {
            if (string.IsNullOrEmpty(word))
                return word;

            int count = 0;
            if (word[word.Length - 1] == giveCharacter)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    if (word[i] == giveCharacter)
                        count++;
                    else
                        break;
                }
            }
            return word.Substring(0, word.Length - count);
        }
    }
}
