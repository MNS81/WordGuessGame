using System;
using System.Text;
using static System.Windows.Forms.LinkLabel;

namespace WordGuessGame
{
    class Words
    {
        public List<String> words = new List<String>();

        public string GetWord()
        {
            string filePath = Path.Combine(Application.StartupPath, "words.db");

            using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    words.Add(line.ToUpper());
                }
            }

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, words.Count);
            return words[randomIndex];
        }
    }
}
