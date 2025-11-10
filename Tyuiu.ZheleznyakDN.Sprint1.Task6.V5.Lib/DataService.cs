using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZheleznyakDN.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";
            
            char[] separators = new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r', '(', ')', '[', ']', '{', '}', '"', '\'' };
            string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> symmetricalWords = new List<string>();

            foreach (string word in words)
            {
                
                if (IsSymmetrical(word))
                {
                    symmetricalWords.Add(word);
                }
            }
            
            return string.Join(", ", symmetricalWords);
        }

        
        private bool IsSymmetrical(string word)
        {
            if (word.Length < 1)
                return false;

            string cleanWord = word.ToLower();
            int length = cleanWord.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (cleanWord[i] != cleanWord[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
