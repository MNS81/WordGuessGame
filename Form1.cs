using System.Media;

namespace WordGuessGame
{
    public partial class Form1 : Form
    {
        private string secretWord;
        private string currentWord;
        private List<String> wordsList;
        private int count = 1;

        public Form1()
        {
            InitializeComponent();
            InitializeNewGame();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5)
                textBox1.Text += ((Button)sender).Text;
        }

        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text[..^1];
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 5)
            {
                currentWord = textBox1.Text;
                if (wordsList.Contains(currentWord))
                {
                    CheckWord();
                    if (count == 1)
                    {
                        button11.Text = textBox1.Text[0].ToString();
                        button12.Text = textBox1.Text[1].ToString();
                        button13.Text = textBox1.Text[2].ToString();
                        button14.Text = textBox1.Text[3].ToString();
                        button15.Text = textBox1.Text[4].ToString();
                        if (secretWord.Contains(button11.Text)) button11.BackColor = Color.Yellow;
                        if (secretWord.Contains(button12.Text)) button12.BackColor = Color.Yellow;
                        if (secretWord.Contains(button13.Text)) button13.BackColor = Color.Yellow;
                        if (secretWord.Contains(button14.Text)) button14.BackColor = Color.Yellow;
                        if (secretWord.Contains(button15.Text)) button15.BackColor = Color.Yellow;
                        if (secretWord[0] == textBox1.Text[0]) button11.BackColor = Color.LightGreen;
                        if (secretWord[1] == textBox1.Text[1]) button12.BackColor = Color.LightGreen;
                        if (secretWord[2] == textBox1.Text[2]) button13.BackColor = Color.LightGreen;
                        if (secretWord[3] == textBox1.Text[3]) button14.BackColor = Color.LightGreen;
                        if (secretWord[4] == textBox1.Text[4]) button15.BackColor = Color.LightGreen;
                    }
                    if (count == 2)
                    {
                        button21.Text = textBox1.Text[0].ToString();
                        button22.Text = textBox1.Text[1].ToString();
                        button23.Text = textBox1.Text[2].ToString();
                        button24.Text = textBox1.Text[3].ToString();
                        button25.Text = textBox1.Text[4].ToString();
                        if (secretWord.Contains(button21.Text)) button21.BackColor = Color.Yellow;
                        if (secretWord.Contains(button22.Text)) button22.BackColor = Color.Yellow;
                        if (secretWord.Contains(button23.Text)) button23.BackColor = Color.Yellow;
                        if (secretWord.Contains(button24.Text)) button24.BackColor = Color.Yellow;
                        if (secretWord.Contains(button25.Text)) button25.BackColor = Color.Yellow;
                        if (secretWord[0] == textBox1.Text[0]) button21.BackColor = Color.LightGreen;
                        if (secretWord[1] == textBox1.Text[1]) button22.BackColor = Color.LightGreen;
                        if (secretWord[2] == textBox1.Text[2]) button23.BackColor = Color.LightGreen;
                        if (secretWord[3] == textBox1.Text[3]) button24.BackColor = Color.LightGreen;
                        if (secretWord[4] == textBox1.Text[4]) button25.BackColor = Color.LightGreen;
                    }
                    if (count == 3)
                    {
                        button31.Text = textBox1.Text[0].ToString();
                        button32.Text = textBox1.Text[1].ToString();
                        button33.Text = textBox1.Text[2].ToString();
                        button34.Text = textBox1.Text[3].ToString();
                        button35.Text = textBox1.Text[4].ToString();
                        if (secretWord.Contains(button31.Text)) button31.BackColor = Color.Yellow;
                        if (secretWord.Contains(button32.Text)) button32.BackColor = Color.Yellow;
                        if (secretWord.Contains(button33.Text)) button33.BackColor = Color.Yellow;
                        if (secretWord.Contains(button34.Text)) button34.BackColor = Color.Yellow;
                        if (secretWord.Contains(button35.Text)) button35.BackColor = Color.Yellow;
                        if (secretWord[0] == textBox1.Text[0]) button31.BackColor = Color.LightGreen;
                        if (secretWord[1] == textBox1.Text[1]) button32.BackColor = Color.LightGreen;
                        if (secretWord[2] == textBox1.Text[2]) button33.BackColor = Color.LightGreen;
                        if (secretWord[3] == textBox1.Text[3]) button34.BackColor = Color.LightGreen;
                        if (secretWord[4] == textBox1.Text[4]) button35.BackColor = Color.LightGreen;
                    }
                    if (count == 4)
                    {
                        button41.Text = textBox1.Text[0].ToString();
                        button42.Text = textBox1.Text[1].ToString();
                        button43.Text = textBox1.Text[2].ToString();
                        button44.Text = textBox1.Text[3].ToString();
                        button45.Text = textBox1.Text[4].ToString();
                        if (secretWord.Contains(button41.Text)) button41.BackColor = Color.Yellow;
                        if (secretWord.Contains(button42.Text)) button42.BackColor = Color.Yellow;
                        if (secretWord.Contains(button43.Text)) button43.BackColor = Color.Yellow;
                        if (secretWord.Contains(button44.Text)) button44.BackColor = Color.Yellow;
                        if (secretWord.Contains(button45.Text)) button45.BackColor = Color.Yellow;
                        if (secretWord[0] == textBox1.Text[0]) button41.BackColor = Color.LightGreen;
                        if (secretWord[1] == textBox1.Text[1]) button42.BackColor = Color.LightGreen;
                        if (secretWord[2] == textBox1.Text[2]) button43.BackColor = Color.LightGreen;
                        if (secretWord[3] == textBox1.Text[3]) button44.BackColor = Color.LightGreen;
                        if (secretWord[4] == textBox1.Text[4]) button45.BackColor = Color.LightGreen;
                    }
                    if (count == 5)
                    {
                        button51.Text = textBox1.Text[0].ToString();
                        button52.Text = textBox1.Text[1].ToString();
                        button53.Text = textBox1.Text[2].ToString();
                        button54.Text = textBox1.Text[3].ToString();
                        button55.Text = textBox1.Text[4].ToString();
                        if (secretWord.Contains(button51.Text)) button51.BackColor = Color.Yellow;
                        if (secretWord.Contains(button52.Text)) button52.BackColor = Color.Yellow;
                        if (secretWord.Contains(button53.Text)) button53.BackColor = Color.Yellow;
                        if (secretWord.Contains(button54.Text)) button54.BackColor = Color.Yellow;
                        if (secretWord.Contains(button55.Text)) button55.BackColor = Color.Yellow;
                        if (secretWord[0] == textBox1.Text[0]) button51.BackColor = Color.LightGreen;
                        if (secretWord[1] == textBox1.Text[1]) button52.BackColor = Color.LightGreen;
                        if (secretWord[2] == textBox1.Text[2]) button53.BackColor = Color.LightGreen;
                        if (secretWord[3] == textBox1.Text[3]) button54.BackColor = Color.LightGreen;
                        if (secretWord[4] == textBox1.Text[4]) button55.BackColor = Color.LightGreen;
                    }
                    if (count == 6)
                    {
                        button61.Text = textBox1.Text[0].ToString();
                        button62.Text = textBox1.Text[1].ToString();
                        button63.Text = textBox1.Text[2].ToString();
                        button64.Text = textBox1.Text[3].ToString();
                        button65.Text = textBox1.Text[4].ToString();
                        if (secretWord.Contains(button61.Text)) button61.BackColor = Color.Yellow;
                        if (secretWord.Contains(button62.Text)) button62.BackColor = Color.Yellow;
                        if (secretWord.Contains(button63.Text)) button63.BackColor = Color.Yellow;
                        if (secretWord.Contains(button64.Text)) button64.BackColor = Color.Yellow;
                        if (secretWord.Contains(button65.Text)) button65.BackColor = Color.Yellow;
                        if (secretWord[0] == textBox1.Text[0]) button61.BackColor = Color.LightGreen;
                        if (secretWord[1] == textBox1.Text[1]) button62.BackColor = Color.LightGreen;
                        if (secretWord[2] == textBox1.Text[2]) button63.BackColor = Color.LightGreen;
                        if (secretWord[3] == textBox1.Text[3]) button64.BackColor = Color.LightGreen;
                        if (secretWord[4] == textBox1.Text[4]) button65.BackColor = Color.LightGreen;
                    }
                    count++;
                    GameOver();
                }
                else if (!wordsList.Contains(currentWord))
                {
                    DialogResult result = MessageBox.Show($"Такого слова нет в словаре.\n\nХотите добавить?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string filePath = Path.Combine(Application.StartupPath, "words.db");
                        using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.WriteLine(currentWord);
                        }
                        wordsList.Add(currentWord);
                        return;
                    }
                    else if (result == DialogResult.No)
                    {
                        currentWord = String.Empty;
                        textBox1.Text = String.Empty;
                    }
                }
            }
        }

        private void CheckWord()
        {
            foreach (char c in currentWord)
            {
                if (secretWord.Contains(c))
                {
                    if (Й.Text == c.ToString()) Й.BackColor = Color.Yellow;
                    if (Ц.Text == c.ToString()) Ц.BackColor = Color.Yellow;
                    if (У.Text == c.ToString()) У.BackColor = Color.Yellow;
                    if (К.Text == c.ToString()) К.BackColor = Color.Yellow;
                    if (Е.Text == c.ToString()) Е.BackColor = Color.Yellow;
                    if (Н.Text == c.ToString()) Н.BackColor = Color.Yellow;
                    if (Г.Text == c.ToString()) Г.BackColor = Color.Yellow;
                    if (Ш.Text == c.ToString()) Ш.BackColor = Color.Yellow;
                    if (Щ.Text == c.ToString()) Щ.BackColor = Color.Yellow;
                    if (З.Text == c.ToString()) З.BackColor = Color.Yellow;
                    if (Х.Text == c.ToString()) Х.BackColor = Color.Yellow;
                    if (Ъ.Text == c.ToString()) Ъ.BackColor = Color.Yellow;
                    if (Ф.Text == c.ToString()) Ф.BackColor = Color.Yellow;
                    if (Ы.Text == c.ToString()) Ы.BackColor = Color.Yellow;
                    if (В.Text == c.ToString()) В.BackColor = Color.Yellow;
                    if (А.Text == c.ToString()) А.BackColor = Color.Yellow;
                    if (П.Text == c.ToString()) П.BackColor = Color.Yellow;
                    if (Р.Text == c.ToString()) Р.BackColor = Color.Yellow;
                    if (О.Text == c.ToString()) О.BackColor = Color.Yellow;
                    if (Л.Text == c.ToString()) Л.BackColor = Color.Yellow;
                    if (Д.Text == c.ToString()) Д.BackColor = Color.Yellow;
                    if (Ж.Text == c.ToString()) Ж.BackColor = Color.Yellow;
                    if (Э.Text == c.ToString()) Э.BackColor = Color.Yellow;
                    if (Я.Text == c.ToString()) Я.BackColor = Color.Yellow;
                    if (Ч.Text == c.ToString()) Ч.BackColor = Color.Yellow;
                    if (С.Text == c.ToString()) С.BackColor = Color.Yellow;
                    if (М.Text == c.ToString()) М.BackColor = Color.Yellow;
                    if (И.Text == c.ToString()) И.BackColor = Color.Yellow;
                    if (Т.Text == c.ToString()) Т.BackColor = Color.Yellow;
                    if (Ь.Text == c.ToString()) Ь.BackColor = Color.Yellow;
                    if (Б.Text == c.ToString()) Б.BackColor = Color.Yellow;
                    if (Ю.Text == c.ToString()) Ю.BackColor = Color.Yellow;
                }
                if (!secretWord.Contains(c))
                {
                    if (Й.Text == c.ToString()) Й.BackColor = Color.Gray;
                    if (Ц.Text == c.ToString()) Ц.BackColor = Color.Gray;
                    if (У.Text == c.ToString()) У.BackColor = Color.Gray;
                    if (К.Text == c.ToString()) К.BackColor = Color.Gray;
                    if (Е.Text == c.ToString()) Е.BackColor = Color.Gray;
                    if (Н.Text == c.ToString()) Н.BackColor = Color.Gray;
                    if (Г.Text == c.ToString()) Г.BackColor = Color.Gray;
                    if (Ш.Text == c.ToString()) Ш.BackColor = Color.Gray;
                    if (Щ.Text == c.ToString()) Щ.BackColor = Color.Gray;
                    if (З.Text == c.ToString()) З.BackColor = Color.Gray;
                    if (Х.Text == c.ToString()) Х.BackColor = Color.Gray;
                    if (Ъ.Text == c.ToString()) Ъ.BackColor = Color.Gray;
                    if (Ф.Text == c.ToString()) Ф.BackColor = Color.Gray;
                    if (Ы.Text == c.ToString()) Ы.BackColor = Color.Gray;
                    if (В.Text == c.ToString()) В.BackColor = Color.Gray;
                    if (А.Text == c.ToString()) А.BackColor = Color.Gray;
                    if (П.Text == c.ToString()) П.BackColor = Color.Gray;
                    if (Р.Text == c.ToString()) Р.BackColor = Color.Gray;
                    if (О.Text == c.ToString()) О.BackColor = Color.Gray;
                    if (Л.Text == c.ToString()) Л.BackColor = Color.Gray;
                    if (Д.Text == c.ToString()) Д.BackColor = Color.Gray;
                    if (Ж.Text == c.ToString()) Ж.BackColor = Color.Gray;
                    if (Э.Text == c.ToString()) Э.BackColor = Color.Gray;
                    if (Я.Text == c.ToString()) Я.BackColor = Color.Gray;
                    if (Ч.Text == c.ToString()) Ч.BackColor = Color.Gray;
                    if (С.Text == c.ToString()) С.BackColor = Color.Gray;
                    if (М.Text == c.ToString()) М.BackColor = Color.Gray;
                    if (И.Text == c.ToString()) И.BackColor = Color.Gray;
                    if (Т.Text == c.ToString()) Т.BackColor = Color.Gray;
                    if (Ь.Text == c.ToString()) Ь.BackColor = Color.Gray;
                    if (Б.Text == c.ToString()) Б.BackColor = Color.Gray;
                    if (Ю.Text == c.ToString()) Ю.BackColor = Color.Gray;
                }
            }
        }

        private void GameOver()
        {
            if (currentWord == secretWord)
            {
                SoundPlayer player = new SoundPlayer(@"tada.wav");
                player.Play();
                DialogResult result = MessageBox.Show($"Вы угадали слово {currentWord}.\nПоздравляю!!!\n\nХотите сыграть еще?", "Игра окончена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) InitializeNewGame();
                else if (result == DialogResult.No) Application.Exit();
            }
            if (count == 7)
            {
                SoundPlayer player = new SoundPlayer(@"spongebob-fail.wav");
                player.Play();
                DialogResult result = MessageBox.Show($"К сожалению, вы проиграли :(\n\nХотите сыграть еще?", "Игра окончена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) InitializeNewGame();
                else if (result == DialogResult.No) Application.Exit();
            }
            textBox1.Text = String.Empty;
        }

        private void InitializeNewGame()
        {
            SoundPlayer player = new SoundPlayer(@"newGame.wav");
            player.Play();
            Words words = new Words();
            secretWord = words.GetWord();
            wordsList = words.words;
            count = 1;
            currentWord = String.Empty;
            textBox1.Text = String.Empty;
            button11.Text = String.Empty;
            button12.Text = String.Empty;
            button13.Text = String.Empty;
            button14.Text = String.Empty;
            button15.Text = String.Empty;
            button21.Text = String.Empty;
            button22.Text = String.Empty;
            button23.Text = String.Empty;
            button24.Text = String.Empty;
            button25.Text = String.Empty;
            button31.Text = String.Empty;
            button32.Text = String.Empty;
            button33.Text = String.Empty;
            button34.Text = String.Empty;
            button35.Text = String.Empty;
            button41.Text = String.Empty;
            button42.Text = String.Empty;
            button43.Text = String.Empty;
            button44.Text = String.Empty;
            button45.Text = String.Empty;
            button51.Text = String.Empty;
            button52.Text = String.Empty;
            button53.Text = String.Empty;
            button54.Text = String.Empty;
            button55.Text = String.Empty;
            button61.Text = String.Empty;
            button62.Text = String.Empty;
            button63.Text = String.Empty;
            button64.Text = String.Empty;
            button65.Text = String.Empty;
            button11.BackColor = Color.LightGray;
            button12.BackColor = Color.LightGray;
            button13.BackColor = Color.LightGray;
            button14.BackColor = Color.LightGray;
            button15.BackColor = Color.LightGray;
            button21.BackColor = Color.LightGray;
            button22.BackColor = Color.LightGray;
            button23.BackColor = Color.LightGray;
            button24.BackColor = Color.LightGray;
            button25.BackColor = Color.LightGray;
            button31.BackColor = Color.LightGray;
            button32.BackColor = Color.LightGray;
            button33.BackColor = Color.LightGray;
            button34.BackColor = Color.LightGray;
            button35.BackColor = Color.LightGray;
            button41.BackColor = Color.LightGray;
            button42.BackColor = Color.LightGray;
            button43.BackColor = Color.LightGray;
            button44.BackColor = Color.LightGray;
            button45.BackColor = Color.LightGray;
            button51.BackColor = Color.LightGray;
            button52.BackColor = Color.LightGray;
            button53.BackColor = Color.LightGray;
            button54.BackColor = Color.LightGray;
            button55.BackColor = Color.LightGray;
            button61.BackColor = Color.LightGray;
            button62.BackColor = Color.LightGray;
            button63.BackColor = Color.LightGray;
            button64.BackColor = Color.LightGray;
            button65.BackColor = Color.LightGray;
            Й.BackColor = Color.LightGray;
            Ц.BackColor = Color.LightGray;
            У.BackColor = Color.LightGray;
            К.BackColor = Color.LightGray;
            Е.BackColor = Color.LightGray;
            Н.BackColor = Color.LightGray;
            Г.BackColor = Color.LightGray;
            Ш.BackColor = Color.LightGray;
            Щ.BackColor = Color.LightGray;
            З.BackColor = Color.LightGray;
            Х.BackColor = Color.LightGray;
            Ъ.BackColor = Color.LightGray;
            Ф.BackColor = Color.LightGray;
            Ы.BackColor = Color.LightGray;
            В.BackColor = Color.LightGray;
            А.BackColor = Color.LightGray;
            П.BackColor = Color.LightGray;
            Р.BackColor = Color.LightGray;
            О.BackColor = Color.LightGray;
            Л.BackColor = Color.LightGray;
            Д.BackColor = Color.LightGray;
            Ж.BackColor = Color.LightGray;
            Э.BackColor = Color.LightGray;
            Я.BackColor = Color.LightGray;
            Ч.BackColor = Color.LightGray;
            С.BackColor = Color.LightGray;
            М.BackColor = Color.LightGray;
            И.BackColor = Color.LightGray;
            Т.BackColor = Color.LightGray;
            Ь.BackColor = Color.LightGray;
            Б.BackColor = Color.LightGray;
            Ю.BackColor = Color.LightGray;
        }
    }
}