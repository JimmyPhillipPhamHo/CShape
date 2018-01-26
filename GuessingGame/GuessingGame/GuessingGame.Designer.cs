namespace WindowsFormsApplication1
{
    partial class GuessingGame
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
            this.txtGuessNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGuessNum
            // 
            this.txtGuessNum.Location = new System.Drawing.Point(177, 95);
            this.txtGuessNum.Name = "txtGuessNum";
            this.txtGuessNum.Size = new System.Drawing.Size(106, 20);
            this.txtGuessNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a guess number\r\n";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(37, 95);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(116, 28);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess the Number";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblResult.Location = new System.Drawing.Point(28, 152);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(200, 40);
            this.lblResult.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(240, 152);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // GuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(327, 213);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGuessNum);
            this.Name = "GuessingGame";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuessNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReset;
    }
}

