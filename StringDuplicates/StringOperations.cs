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
    }
}
