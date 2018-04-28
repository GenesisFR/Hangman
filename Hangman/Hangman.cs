using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Hangman : Form
    {
        const int MAX_GUESSES = 5;

        bool _isGameOver;
        int _guessesLeft;
        List<string> _wordList;
        string _currentWord;
        Random _random;

        public Hangman()
        {
            InitializeComponent();

            _isGameOver = false;
            _guessesLeft = MAX_GUESSES;
            _wordList = new List<string>();
            _currentWord = String.Empty;
            _random = new Random();

            ReadWordFile();
        }

        void PickRandomWord()
        {
            _currentWord = _wordList[_random.Next(_wordList.Count)];
        }

        void ReadWordFile()
        {
            // read the "words.txt" file and store the words in an array of strings
            _wordList.AddRange(File.ReadAllLines("words.txt"));
        }

        void ResetWordLabel()
        {
            labelWord.Text = new string('-', _currentWord.Length);
        }

        void RevealCharacter(char character)
        {
            char[] formattedWord = labelWord.Text.ToCharArray();
            
            for (int i = 0; i < _currentWord.Length; i++)
            {
                if (_currentWord[i] == character)
                    formattedWord[i] = _currentWord[i];
            }

            labelWord.Text = new string(formattedWord);
        }

        
        private void UpdateAvailableWordsLabel()
        {
            labelAvailableWords.Text = $"Available words: {_wordList.Count - 1}";
        }

        private void UpdateGuessesLeftLabel()
        {
            labelGuessesLeft.Text = $"Guesses left: {_guessesLeft}";
        }

        // event handlers
        private void ButtonNextWord_Click(object sender, EventArgs e)
        {
            // remove current word from the list
            if (checkBoxRemovePreviousWords.Checked)
            {
                _wordList.Remove(_currentWord);
                UpdateAvailableWordsLabel();
            }

            _isGameOver = false;
            _guessesLeft = MAX_GUESSES;
            _currentWord = String.Empty;
            UpdateGuessesLeftLabel();

            // pick a random word
            PickRandomWord();

            // fill the word label with '-' characters
            ResetWordLabel();

            buttonNextWord.Enabled = _wordList.Count > 1;
        }

        private void Hangman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_isGameOver)
                return;

            // correct guess
            if (_currentWord.Contains(e.KeyChar.ToString()))
            {
                // replace all the occurrences of the pressed key by the corresponding letter
                RevealCharacter(e.KeyChar);

                // no more _ characters, game is over
                _isGameOver = !labelWord.Text.Contains("-");

                // game is over, play a success sound
                if (_isGameOver)
                    SystemSounds.Asterisk.Play();
            }
            // incorrect guess
            else
            {
                // play an error sound
                SystemSounds.Hand.Play();

                // decrease the counter of guesses left
                --_guessesLeft;
                UpdateGuessesLeftLabel();

                // no more guesses left, game is over
                _isGameOver = _guessesLeft == 0;

                // reveal word
                if (_isGameOver)
                    labelWord.Text = _currentWord;
            }
        }

        private void Hangman_Load(object sender, EventArgs e)
        {
            buttonNextWord.PerformClick();
        }
    }
}
