using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public class Counter
    {
        public char[] Punctuation { get; }
        public string Sentence { get; }
        public string Search { get; }
        public Counter(string sentence, string word)
        {
            Sentence = sentence.ToLower();
            Search = word.ToLower().Trim();
            Punctuation = new char[]{'\'','"','!','.','?','(',')',',',';',':','`' };
        }

        public static bool CheckForContent(string input)
        {
            bool hasContent = true;
            if(input == "")
            {
                hasContent = false;
            }
            return hasContent;
        }

        public int CheckWord(string word)
        {
            int count = 0;
            if(word == Search)
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

        public List<string> MakeSentenceList()
        {
            List<string> sentenceList = new List<string>();
            string modifiedSentence = Sentence;
            while(modifiedSentence.Contains(" "))
            {
                int indexOfFirstSpace = modifiedSentence.IndexOf(" ");
                sentenceList.Add(modifiedSentence.Substring(0,indexOfFirstSpace));
                modifiedSentence = modifiedSentence.Substring(indexOfFirstSpace+1);
            }
            sentenceList.Add(modifiedSentence);
            return sentenceList;
        }

        public string RemoveOneSidePunctuation(string word)
        {
            for(int i = 0; i<word.Length; i++)
            {
                bool charRemoved = false;
                foreach(char c in Punctuation)
                {
                    if(c == word[i])
                    {
                        word = word.Substring(word.IndexOf(c)+1);
                        charRemoved = true;
                    }
                }
                if(!charRemoved){
                    break;
                }
            }

            return word;
        }

        public string RemoveAllPunctuation(string word)
        {
            for(int i = 0; i < 2; i++)
            {
                word = RemoveOneSidePunctuation(word);
                word = word.Select(character => character.ToString()).Aggregate<string>((first,second) => second + first);
            }

            return word;
        }
        

        public int CountWordsInSentence(List<string> sentenceList)
        {
            int wordCount = 0;
            foreach(string word in sentenceList)
            {
                string modifiedWord = RemoveAllPunctuation(word);
                wordCount += CheckWord(modifiedWord);
            }
            return wordCount;
        }
    }
}