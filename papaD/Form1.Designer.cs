namespace papaD
{
    partial class Form1
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
            this.storyline = new System.Windows.Forms.Label();
            this.mOption = new System.Windows.Forms.Label();
            this.bOption = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // storyline
            // 
            this.storyline.Location = new System.Drawing.Point(9, 7);
            this.storyline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.storyline.Name = "storyline";
            this.storyline.Size = new System.Drawing.Size(294, 47);
            this.storyline.TabIndex = 0;
            this.storyline.Text = "SOVIET UNION 2 ELECTRIC BOOGALOO IM GOING TO ANNEX YOU";
            // 
            // mOption
            // 
            this.mOption.AutoSize = true;
            this.mOption.Location = new System.Drawing.Point(9, 158);
            this.mOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mOption.Name = "mOption";
            this.mOption.Size = new System.Drawing.Size(15, 13);
            this.mOption.TabIndex = 1;
            this.mOption.Text = "m";
            // 
            // bOption
            // 
            this.bOption.AutoSize = true;
            this.bOption.Location = new System.Drawing.Point(9, 229);
            this.bOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bOption.Name = "bOption";
            this.bOption.Size = new System.Drawing.Size(13, 13);
            this.bOption.TabIndex = 2;
            this.bOption.Text = "b";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bOption);
            this.Controls.Add(this.mOption);
            this.Controls.Add(this.storyline);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storyline;
        private System.Windows.Forms.Label mOption;
        private System.Windows.Forms.Label bOption;
        private System.Windows.Forms.Button button1;
    }
}

