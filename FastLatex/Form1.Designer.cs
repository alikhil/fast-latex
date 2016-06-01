namespace FastLatex
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetLatexBtn = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.CreateWithParagraphCBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetLatexBtn
            // 
            this.GetLatexBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.GetLatexBtn.Location = new System.Drawing.Point(311, 0);
            this.GetLatexBtn.Name = "GetLatexBtn";
            this.GetLatexBtn.Size = new System.Drawing.Size(117, 27);
            this.GetLatexBtn.TabIndex = 0;
            this.GetLatexBtn.Text = "Get Latex";
            this.GetLatexBtn.UseVisualStyleBackColor = true;
            this.GetLatexBtn.Click += new System.EventHandler(this.GetLatexBtn_Click);
            // 
            // InputBox
            // 
            this.InputBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputBox.Location = new System.Drawing.Point(0, 0);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(428, 20);
            this.InputBox.TabIndex = 1;
            // 
            // OutputBox
            // 
            this.OutputBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OutputBox.Location = new System.Drawing.Point(0, 47);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(428, 339);
            this.OutputBox.TabIndex = 2;
            // 
            // CreateWithParagraphCBox
            // 
            this.CreateWithParagraphCBox.AutoSize = true;
            this.CreateWithParagraphCBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CreateWithParagraphCBox.Location = new System.Drawing.Point(0, 0);
            this.CreateWithParagraphCBox.Name = "CreateWithParagraphCBox";
            this.CreateWithParagraphCBox.Size = new System.Drawing.Size(86, 27);
            this.CreateWithParagraphCBox.TabIndex = 3;
            this.CreateWithParagraphCBox.Text = "In paragraph";
            this.CreateWithParagraphCBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GetLatexBtn);
            this.panel1.Controls.Add(this.CreateWithParagraphCBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 27);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.Name = "MainForm";
            this.Text = "Fast Latex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetLatexBtn;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.CheckBox CreateWithParagraphCBox;
        private System.Windows.Forms.Panel panel1;
    }
}

