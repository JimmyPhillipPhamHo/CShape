﻿namespace DailySpecial
{
    partial class ChatterboxDinerDailySpecial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetSpecial = new System.Windows.Forms.Button();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a day number to see our special";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "For example, Sunday = 1";
            // 
            // btnGetSpecial
            // 
            this.btnGetSpecial.Location = new System.Drawing.Point(158, 205);
            this.btnGetSpecial.Name = "btnGetSpecial";
            this.btnGetSpecial.Size = new System.Drawing.Size(75, 23);
            this.btnGetSpecial.TabIndex = 2;
            this.btnGetSpecial.Text = "Get special";
            this.btnGetSpecial.UseVisualStyleBackColor = true;
            this.btnGetSpecial.Click += new System.EventHandler(this.btnGetSpecial_Click);
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(173, 146);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(48, 20);
            this.txtDay.TabIndex = 3;
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Location = new System.Drawing.Point(136, 250);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(0, 13);
            this.lblSpecial.TabIndex = 4;
            // 
            // ChatterboxDinerDailySpecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 349);
            this.Controls.Add(this.lblSpecial);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.btnGetSpecial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChatterboxDinerDailySpecial";
            this.Text = "Chatterbox Diner DailySpecial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetSpecial;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lblSpecial;
    }
}

