namespace Tic_Tac_Toe
{
    partial class TicTacToe
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
            this.mainUpperLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainUpperLabel
            // 
            this.mainUpperLabel.AutoSize = true;
            this.mainUpperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainUpperLabel.Location = new System.Drawing.Point(44, 9);
            this.mainUpperLabel.Name = "mainUpperLabel";
            this.mainUpperLabel.Size = new System.Drawing.Size(254, 24);
            this.mainUpperLabel.TabIndex = 0;
            this.mainUpperLabel.Text = "Welcome To Tic Tac Toe!";
            this.mainUpperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 57);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 57);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 57);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(76, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 57);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(140, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 57);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(204, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 57);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(76, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 57);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(140, 199);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 57);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(204, 199);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 57);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "X Goes Next!";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(140, 287);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(75, 23);
            this.playAgainButton.TabIndex = 11;
            this.playAgainButton.Text = "Play Again?";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Visible = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 334);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainUpperLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainUpperLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playAgainButton;
    }
}

