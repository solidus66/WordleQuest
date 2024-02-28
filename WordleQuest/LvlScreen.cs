using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WordleQuest
{
    public partial class LvlScreen : Form
    {
        private string _levelNotification;
        private Random rand = new Random();
        private int CurrentOffset = 1;
        private string CurrentWord = string.Empty;
        private List<string> WordList = new List<string>();
        private List<TextBox> currentBoxes = new List<TextBox>();

        public LvlScreen(string levelNotification)
        {
            InitializeComponent();
            WordList = GetAllWords();
            StartNewGame();
            BindTextChangedEvents();

            this.AcceptButton = submitWord;
            _levelNotification = levelNotification;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 startScreen = new Form1();
            startScreen.ShowDialog();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void BindTextChangedEvents()
        {
            for (int row = 1; row <= 6; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    TextBox textBox = (TextBox)Controls.Find($"r{row}s{col}", true).FirstOrDefault();
                    if (textBox != null)
                    {
                        textBox.TextChanged += TextBox_TextChanged;
                        textBox.KeyDown += TextBox_KeyDown;
                        textBox.KeyDown += TextBox_KeyDownEnter;
                    }
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;

            if (currentTextBox.Text.Length == 1)
            {
                int rowIndex = int.Parse(currentTextBox.Name[1].ToString());
                int colIndex = int.Parse(currentTextBox.Name[3].ToString());

                int nextColIndex = colIndex + 1;
                if (nextColIndex <= 5)
                {
                    TextBox nextTextBox = (TextBox)Controls.Find($"r{rowIndex}s{nextColIndex}", true).FirstOrDefault();
                    nextTextBox?.Focus();
                }
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox currentTextBox = (TextBox)sender;

            if (e.KeyCode == Keys.Back && currentTextBox.SelectionStart == 0 && currentTextBox.SelectionLength == 0)
            {
                int rowIndex = int.Parse(currentTextBox.Name[1].ToString());
                int colIndex = int.Parse(currentTextBox.Name[3].ToString());

                int prevColIndex = colIndex - 1;
                if (prevColIndex >= 1)
                {
                    TextBox prevTextBox = (TextBox)Controls.Find($"r{rowIndex}s{prevColIndex}", true).FirstOrDefault();
                    prevTextBox?.Focus();
                    prevTextBox?.Clear();
                }
                else
                {
                    int prevRowIndex = rowIndex - 1;
                    if (prevRowIndex >= 1)
                    {
                        TextBox prevRowTextBox = (TextBox)Controls.Find($"r{prevRowIndex}s5", true).FirstOrDefault();
                        prevRowTextBox?.Focus();
                        prevRowTextBox?.Clear();
                    }
                }
            }
        }

        private void TextBox_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitWord_Click(sender, e);
            }
        }

        private void StartNewGame()
        {
            this.Controls.Clear();
            InitializeComponent();
            BindTextChangedEvents();

            CurrentWord = WordList[rand.Next(WordList.Count)];
            CurrentOffset = 1;
            submitWord.Enabled = true;
        }

        private List<string> GetAllWords()
        {
            List<string> allWords = new List<string>();
            using (StreamReader reader = new StreamReader("words.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var nextLine = reader.ReadLine();
                    allWords.Add(nextLine);
                }
            }
            return allWords;
        }

        private void submitWord_Click(object sender, EventArgs e)
        {
            var userWord = GetInput();

            if (!ValidateInput(userWord))
            {
                return;
            }

            bool isCorrect = IsCorrectWord(userWord);

            for (int i = 0; i < currentBoxes.Count(); i++)
            {
                ColorBox(i, currentBoxes[i]);
            }

            if (isCorrect)
            {
                EndGame();
                return;
            }

            CurrentOffset++;
            if (CurrentOffset > 6)
            {
                MessageBox.Show("Не получилось... Попробуй ещё раз!" +
                    "Правильное слово было: " + CurrentWord);
                submitWord.Enabled = false;
            }
        }

        private void ColorBox(int index, TextBox t)
        {
            if (!CurrentWord.Contains(t.Text, StringComparison.OrdinalIgnoreCase))
            {
                t.BackColor = Color.Gray;
            }
            else if (CurrentWord[index].ToString().ToLower() != t.Text.ToLower())
            {
                t.BackColor = ColorTranslator.FromHtml("#FFE70A");
            }
            else
            {
                t.BackColor = ColorTranslator.FromHtml("#A4DA8B");
            }
        }

        private void EndGame()
        {
            MessageBox.Show(_levelNotification, "КОНГРАТС");
            submitWord.Enabled = false;
        }

        private string GetInput()
        {
            currentBoxes = new List<TextBox>();

            string tempString = String.Empty;

            switch (CurrentOffset)
            {
                case 1:
                    tempString = r1s1.Text
                            + r1s2.Text
                            + r1s3.Text
                            + r1s4.Text
                            + r1s5.Text;
                    currentBoxes.Add(r1s1);
                    currentBoxes.Add(r1s2);
                    currentBoxes.Add(r1s3);
                    currentBoxes.Add(r1s4);
                    currentBoxes.Add(r1s5);
                    break;
                case 2:
                    tempString = r2s1.Text
                            + r2s2.Text
                            + r2s3.Text
                            + r2s4.Text
                            + r2s5.Text;
                    currentBoxes.Add(r2s1);
                    currentBoxes.Add(r2s2);
                    currentBoxes.Add(r2s3);
                    currentBoxes.Add(r2s4);
                    currentBoxes.Add(r2s5);
                    break;
                case 3:
                    tempString = r3s1.Text
                            + r3s2.Text
                            + r3s3.Text
                            + r3s4.Text
                            + r3s5.Text;
                    currentBoxes.Add(r3s1);
                    currentBoxes.Add(r3s2);
                    currentBoxes.Add(r3s3);
                    currentBoxes.Add(r3s4);
                    currentBoxes.Add(r3s5);
                    break;
                case 4:
                    tempString = r4s1.Text
                            + r4s2.Text
                            + r4s3.Text
                            + r4s4.Text
                            + r4s5.Text;
                    currentBoxes.Add(r4s1);
                    currentBoxes.Add(r4s2);
                    currentBoxes.Add(r4s3);
                    currentBoxes.Add(r4s4);
                    currentBoxes.Add(r4s5);
                    break;
                case 5:
                    tempString = r5s1.Text
                            + r5s2.Text
                            + r5s3.Text
                            + r5s4.Text
                            + r5s5.Text;
                    currentBoxes.Add(r5s1);
                    currentBoxes.Add(r5s2);
                    currentBoxes.Add(r5s3);
                    currentBoxes.Add(r5s4);
                    currentBoxes.Add(r5s5);
                    break;
                case 6:
                    tempString = r6s1.Text
                            + r6s2.Text
                            + r6s3.Text
                            + r6s4.Text
                            + r6s5.Text;
                    currentBoxes.Add(r6s1);
                    currentBoxes.Add(r6s2);
                    currentBoxes.Add(r6s3);
                    currentBoxes.Add(r6s4);
                    currentBoxes.Add(r6s5);
                    break;
            }
            return tempString;
        }

        private bool ValidateInput(string input)
        {
            Regex rx = new Regex("^[а-яА-Я]+");

            input = input.Trim();

            if (input.Length == 5 && rx.IsMatch(input))
            {
                return true;
            }

            MessageBox.Show("Пожалуйста, введи пятибуквенное слово.", "Еррор");
            return false;
        }

        private bool IsCorrectWord(string attempt)
        {
            return CurrentWord.Equals(attempt, StringComparison.OrdinalIgnoreCase);
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Эта информация поможет тебе жить:\nСлова вводятся с клавиатуры, применяются кнопкой Enter.\nДля перехода на новую строку можно использовать мышку или Tab.", "Справка");
        }

        private void testCheat_Click(object sender, EventArgs e)
        {
            testCheat.Text = CurrentWord;
        }
    }
}
