namespace WordCounter.Models
{
    public class Counter
    {
        public static int CheckWord(string sentence, string word)
        {
            int count = 0;
            if(sentence == word)
            {
                count++;
            }
            return count;
        }
    }
}