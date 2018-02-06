namespace PoliticalFever
{
    partial class PoliticalFever
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
            this.txtDelegate = new System.Windows.Forms.TextBox();
            this.txtCandidate1 = new System.Windows.Forms.TextBox();
            this.txtCandidate2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDelegate
            // 
            this.txtDelegate.Location = new System.Drawing.Point(49, 120);
            this.txtDelegate.Name = "txtDelegate";
            this.txtDelegate.Size = new System.Drawing.Size(100, 20);
            this.txtDelegate.TabIndex = 0;
            // 
            // txtCandidate1
            // 
            this.txtCandidate1.Location = new System.Drawing.Point(168, 120);
            this.txtCandidate1.Name = "txtCandidate1";
            this.txtCandidate1.Size = new System.Drawing.Size(100, 20);
            this.txtCandidate1.TabIndex = 1;
            // 
            // txtCandidate2
            // 
            this.txtCandidate2.Location = new System.Drawing.Point(285, 120);
            this.txtCandidate2.Name = "txtCandidate2";
            this.txtCandidate2.Size = new System.Drawing.Size(100, 20);
            this.txtCandidate2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Delegate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Candidate 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Candidate 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter the number the delegate and the percents of votes \r\nfor candidate 1 and can" +
    "didate 2";
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(150, 189);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(75, 23);
            this.btnResults.TabIndex = 7;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // PoliticalFever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 295);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCandidate2);
            this.Controls.Add(this.txtCandidate1);
            this.Controls.Add(this.txtDelegate);
            this.Name = "PoliticalFever";
            this.Text = "Political Fever";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDelegate;
        private System.Windows.Forms.TextBox txtCandidate1;
        private System.Windows.Forms.TextBox txtCandidate2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnResults;
    }
}

