namespace KS
{
    partial class FILE
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
            this.m_file = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDC_FILEOK_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_file
            // 
            this.m_file.Location = new System.Drawing.Point(52, 104);
            this.m_file.Name = "m_file";
            this.m_file.Size = new System.Drawing.Size(270, 23);
            this.m_file.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите имя файла";
            // 
            // IDC_FILEOK_BUTTON
            // 
            this.IDC_FILEOK_BUTTON.Location = new System.Drawing.Point(153, 133);
            this.IDC_FILEOK_BUTTON.Name = "IDC_FILEOK_BUTTON";
            this.IDC_FILEOK_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.IDC_FILEOK_BUTTON.TabIndex = 2;
            this.IDC_FILEOK_BUTTON.Text = "Ок";
            this.IDC_FILEOK_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_FILEOK_BUTTON.Click += new System.EventHandler(this.IDC_FILEOK_BUTTON_Click);
            // 
            // FILE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 240);
            this.Controls.Add(this.IDC_FILEOK_BUTTON);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_file);
            this.Name = "FILE";
            this.Text = "FILE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IDC_FILEOK_BUTTON;
    }
}