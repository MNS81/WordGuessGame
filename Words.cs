using System.Text;

namespace WordGuessGame
{
    class Words
    {
        public List<String> words = new List<String>();

        public string GetWord()
        {
            using (StreamReader sr = new StreamReader(@"Data\words.db", Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line.ToUpper().Replace("Ё", "Е"));
                }
            }

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, words.Count);
            return words[randomIndex];
        }
    }
}
