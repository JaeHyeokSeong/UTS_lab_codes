namespace Program2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_bold = new System.Windows.Forms.Button();
            this.button_sizePlus = new System.Windows.Forms.Button();
            this.button_sizeMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(53, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(690, 252);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_clear.Location = new System.Drawing.Point(92, 327);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(112, 34);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_bold
            // 
            this.button_bold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_bold.Location = new System.Drawing.Point(253, 327);
            this.button_bold.Name = "button_bold";
            this.button_bold.Size = new System.Drawing.Size(112, 34);
            this.button_bold.TabIndex = 2;
            this.button_bold.Text = "Bold";
            this.button_bold.UseVisualStyleBackColor = true;
            this.button_bold.Click += new System.EventHandler(this.button_bold_Click);
            // 
            // button_sizePlus
            // 
            this.button_sizePlus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_sizePlus.Location = new System.Drawing.Point(417, 327);
            this.button_sizePlus.Name = "button_sizePlus";
            this.button_sizePlus.Size = new System.Drawing.Size(112, 34);
            this.button_sizePlus.TabIndex = 3;
            this.button_sizePlus.Text = "Size+";
            this.button_sizePlus.UseVisualStyleBackColor = true;
            this.button_sizePlus.Click += new System.EventHandler(this.button_sizePlus_Click);
            // 
            // button_sizeMinus
            // 
            this.button_sizeMinus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_sizeMinus.Location = new System.Drawing.Point(583, 327);
            this.button_sizeMinus.Name = "button_sizeMinus";
            this.button_sizeMinus.Size = new System.Drawing.Size(112, 34);
            this.button_sizeMinus.TabIndex = 4;
            this.button_sizeMinus.Text = "Size-";
            this.button_sizeMinus.UseVisualStyleBackColor = true;
            this.button_sizeMinus.Click += new System.EventHandler(this.button_sizeMinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.button_sizeMinus);
            this.Controls.Add(this.button_sizePlus);
            this.Controls.Add(this.button_bold);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "RichTextboxDemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button_clear;
        private Button button_bold;
        private Button button_sizePlus;
        private Button button_sizeMinus;
    }
}