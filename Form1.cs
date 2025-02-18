using System.Media;

namespace WordGuessGame
{
    public partial class Form1 : Form
    {
        private string secretWord;
        private int count = 1;
        private List<Button> alphabetButtons = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            InitializeAlphabet();
            InitializeNewGame();
        }

        private void InitializeAlphabet()
        {
            string russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            foreach (char letter in russianAlphabet)
            {
                Button button = new Button
                {
                    Text = letter.ToString().ToUpper(),
                    Size = new Size(40, 40),
                    Margin = new Padding(2),
                    Tag = letter.ToString()
                };
                button.Click += AlphabetButton_Click;
                alphabetButtons.Add(button);
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void AlphabetButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string letter = clickedButton.Tag.ToString();
            if (textBox1.Text.Length < 5)
                textBox1.Text += letter;
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
        }

        private void GameOver()
        {
            if (textBox1.Text == secretWord)
            {
                SoundPlayer player = new SoundPlayer("C:\\Windows\\Media\\tada.wav");
                player.Play();
                DialogResult result = MessageBox.Show($"Вы угадали слово {textBox1.Text}.\nПоздравляю!!!\n\nХотите сыграть еще?", "Игра окончена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) InitializeNewGame();
                else if (result == DialogResult.No) Application.Exit();
            }
            if (count == 7)
            {
                DialogResult result = MessageBox.Show($"К сожалению, вы проиграли :(\n\nХотите сыграть еще?", "Игра окончена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) InitializeNewGame();
                else if (result == DialogResult.No) Application.Exit();
            }
            textBox1.Text = String.Empty;
        }

        private void InitializeNewGame()
        {
            Words words = new Words();
            secretWord = words.GetWord();
            count = 1;
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
        }
    }
}
