namespace Chapter_3
{
    partial class HelloVisualWorld
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
            this.btnClickHere = new System.Windows.Forms.Button();
            this.btnClickMeLast = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickHere
            // 
            this.btnClickHere.Location = new System.Drawing.Point(99, 150);
            this.btnClickHere.Name = "btnClickHere";
            this.btnClickHere.Size = new System.Drawing.Size(89, 35);
            this.btnClickHere.TabIndex = 0;
            this.btnClickHere.Text = "Click Here";
            this.btnClickHere.UseVisualStyleBackColor = true;
            this.btnClickHere.Click += new System.EventHandler(this.btnClickHere_Click);
            // 
            // btnClickMeLast
            // 
            this.btnClickMeLast.Enabled = false;
            this.btnClickMeLast.Location = new System.Drawing.Point(99, 191);
            this.btnClickMeLast.Name = "btnClickMeLast";
            this.btnClickMeLast.Size = new System.Drawing.Size(89, 35);
            this.btnClickMeLast.TabIndex = 1;
            this.btnClickMeLast.Text = "Click Me Last";
            this.btnClickMeLast.UseVisualStyleBackColor = true;
            this.btnClickMeLast.Click += new System.EventHandler(this.btnClickMeLast_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(96, 79);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(99, 13);
            this.lblHelloWorld.TabIndex = 2;
            this.lblHelloWorld.Text = "Hello, Visual World!\r\n";
            this.lblHelloWorld.Visible = false;
            // 
            // HelloVisualWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickMeLast);
            this.Controls.Add(this.btnClickHere);
            this.Name = "HelloVisualWorld";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickHere;
        private System.Windows.Forms.Button btnClickMeLast;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

