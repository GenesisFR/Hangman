namespace Hangman
{
    partial class Hangman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGuessesLeft = new System.Windows.Forms.Label();
            this.labelWord = new System.Windows.Forms.Label();
            this.buttonNextWord = new System.Windows.Forms.Button();
            this.checkBoxRemovePreviousWords = new System.Windows.Forms.CheckBox();
            this.labelAvailableWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGuessesLeft
            // 
            this.labelGuessesLeft.AutoSize = true;
            this.labelGuessesLeft.BackColor = System.Drawing.SystemColors.Control;
            this.labelGuessesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessesLeft.Location = new System.Drawing.Point(10, 10);
            this.labelGuessesLeft.Name = "labelGuessesLeft";
            this.labelGuessesLeft.Size = new System.Drawing.Size(77, 13);
            this.labelGuessesLeft.TabIndex = 0;
            this.labelGuessesLeft.Text = "Guesses left: 5";
            // 
            // labelWord
            // 
            this.labelWord.BackColor = System.Drawing.Color.White;
            this.labelWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.Location = new System.Drawing.Point(12, 26);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(776, 80);
            this.labelWord.TabIndex = 1;
            this.labelWord.Text = "----------";
            this.labelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNextWord
            // 
            this.buttonNextWord.AutoSize = true;
            this.buttonNextWord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNextWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextWord.Location = new System.Drawing.Point(337, 113);
            this.buttonNextWord.Name = "buttonNextWord";
            this.buttonNextWord.Size = new System.Drawing.Size(120, 36);
            this.buttonNextWord.TabIndex = 2;
            this.buttonNextWord.Text = "Next word";
            this.buttonNextWord.UseVisualStyleBackColor = true;
            this.buttonNextWord.Click += new System.EventHandler(this.ButtonNextWord_Click);
            // 
            // checkBoxRemovePreviousWords
            // 
            this.checkBoxRemovePreviousWords.AutoSize = true;
            this.checkBoxRemovePreviousWords.Checked = true;
            this.checkBoxRemovePreviousWords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRemovePreviousWords.Location = new System.Drawing.Point(648, 6);
            this.checkBoxRemovePreviousWords.Name = "checkBoxRemovePreviousWords";
            this.checkBoxRemovePreviousWords.Size = new System.Drawing.Size(140, 17);
            this.checkBoxRemovePreviousWords.TabIndex = 3;
            this.checkBoxRemovePreviousWords.Text = "Remove previous words";
            this.checkBoxRemovePreviousWords.UseVisualStyleBackColor = true;
            // 
            // labelAvailableWords
            // 
            this.labelAvailableWords.AutoSize = true;
            this.labelAvailableWords.BackColor = System.Drawing.SystemColors.Control;
            this.labelAvailableWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableWords.Location = new System.Drawing.Point(690, 132);
            this.labelAvailableWords.Name = "labelAvailableWords";
            this.labelAvailableWords.Size = new System.Drawing.Size(93, 13);
            this.labelAvailableWords.TabIndex = 4;
            this.labelAvailableWords.Text = "Available words: 0";
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 156);
            this.Controls.Add(this.labelAvailableWords);
            this.Controls.Add(this.checkBoxRemovePreviousWords);
            this.Controls.Add(this.buttonNextWord);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.labelGuessesLeft);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Hangman_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hangman_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelGuessesLeft;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Button buttonNextWord;
        private System.Windows.Forms.CheckBox checkBoxRemovePreviousWords;
        private System.Windows.Forms.Label labelAvailableWords;
    }
}

