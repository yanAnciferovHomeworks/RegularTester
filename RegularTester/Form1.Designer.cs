namespace RegularTester
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
            this.GroupRegularEx = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.IsMultiline = new System.Windows.Forms.CheckBox();
            this.IsRegister = new System.Windows.Forms.CheckBox();
            this.RegularText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GruopResul = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.ListBox();
            this.GroupRegularEx.SuspendLayout();
            this.GruopResul.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupRegularEx
            // 
            this.GroupRegularEx.Controls.Add(this.label2);
            this.GroupRegularEx.Controls.Add(this.TextBox);
            this.GroupRegularEx.Controls.Add(this.IsMultiline);
            this.GroupRegularEx.Controls.Add(this.IsRegister);
            this.GroupRegularEx.Controls.Add(this.RegularText);
            this.GroupRegularEx.Controls.Add(this.label1);
            this.GroupRegularEx.Location = new System.Drawing.Point(13, 3);
            this.GroupRegularEx.Name = "GroupRegularEx";
            this.GroupRegularEx.Size = new System.Drawing.Size(557, 511);
            this.GroupRegularEx.TabIndex = 0;
            this.GroupRegularEx.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Текст";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(9, 97);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(542, 405);
            this.TextBox.TabIndex = 4;
            this.TextBox.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // IsMultiline
            // 
            this.IsMultiline.AutoSize = true;
            this.IsMultiline.Location = new System.Drawing.Point(134, 60);
            this.IsMultiline.Name = "IsMultiline";
            this.IsMultiline.Size = new System.Drawing.Size(138, 17);
            this.IsMultiline.TabIndex = 3;
            this.IsMultiline.Text = "многострочный поиск";
            this.IsMultiline.UseVisualStyleBackColor = true;
            this.IsMultiline.CheckedChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // IsRegister
            // 
            this.IsRegister.AutoSize = true;
            this.IsRegister.Location = new System.Drawing.Point(9, 60);
            this.IsRegister.Name = "IsRegister";
            this.IsRegister.Size = new System.Drawing.Size(119, 17);
            this.IsRegister.TabIndex = 2;
            this.IsRegister.Text = "с учетом регистра";
            this.IsRegister.UseVisualStyleBackColor = true;
            this.IsRegister.CheckedChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // RegularText
            // 
            this.RegularText.Location = new System.Drawing.Point(9, 33);
            this.RegularText.Name = "RegularText";
            this.RegularText.Size = new System.Drawing.Size(542, 20);
            this.RegularText.TabIndex = 1;
            this.RegularText.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регулярное выражение";
            // 
            // GruopResul
            // 
            this.GruopResul.Controls.Add(this.label3);
            this.GruopResul.Controls.Add(this.Result);
            this.GruopResul.Location = new System.Drawing.Point(576, 3);
            this.GruopResul.Name = "GruopResul";
            this.GruopResul.Size = new System.Drawing.Size(401, 511);
            this.GruopResul.TabIndex = 1;
            this.GruopResul.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Результаты";
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.Location = new System.Drawing.Point(10, 32);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(385, 472);
            this.Result.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 526);
            this.Controls.Add(this.GruopResul);
            this.Controls.Add(this.GroupRegularEx);
            this.Name = "Form1";
            this.GroupRegularEx.ResumeLayout(false);
            this.GroupRegularEx.PerformLayout();
            this.GruopResul.ResumeLayout(false);
            this.GruopResul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupRegularEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.CheckBox IsMultiline;
        private System.Windows.Forms.CheckBox IsRegister;
        private System.Windows.Forms.TextBox RegularText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GruopResul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Result;
    }
}

