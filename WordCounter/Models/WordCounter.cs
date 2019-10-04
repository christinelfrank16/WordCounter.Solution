namespace WordCounter.Models
{
    public class Counter
    {
        string Sentence { get; }
        string Search { get; }
        public Counter(string sentence, string word)
        {
            Sentence = sentence.ToLower();
            Search = word.ToLower().Trim();
        }

        public static bool CheckForContent(string input)
        {
            return true;
        }
        
        public int CheckWord()
        {
            int count = 0;
            if(Sentence == Search)
            {
                count++;
            }
            return count;
        }

        public bool IsOneWord()
        {
            bool isOneWord = true;
            if(Search.Contains(" "))
            {
                isOneWord = false;
            }
            return isOneWord;
        }
    }
}