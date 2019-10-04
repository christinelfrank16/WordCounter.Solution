namespace WordCounter.Models
{
    public class Counter
    {
        public static int CheckWord(string sentence, string word)
        {
            int count = 0;
            if(sentence.ToLower() == word.ToLower())
            {
                count++;
            }
            return count;
        }

        public static bool IsOneWord(string word)
        {
            bool isOneWord = true;
            if(word.Contains(" "))
            {
                isOneWord = false;
            }
            return isOneWord;
        }
    }
}