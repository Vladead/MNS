namespace KS
{
    partial class TRI
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
            this.m_nexttri = new System.Windows.Forms.TextBox();
            this.IDC_NEXTRR_BUTTON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_nptri1 = new System.Windows.Forms.TextBox();
            this.m_nmtri1 = new System.Windows.Forms.TextBox();
            this.m_ztri = new System.Windows.Forms.TextBox();
            this.m_nmtri2 = new System.Windows.Forms.TextBox();
            this.m_nptri2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Трансформатор, идеальный";
            // 
            // m_nexttri
            // 
            this.m_nexttri.Location = new System.Drawing.Point(181, 23);
            this.m_nexttri.Name = "m_nexttri";
            this.m_nexttri.ReadOnly = true;
            this.m_nexttri.Size = new System.Drawing.Size(100, 23);
            this.m_nexttri.TabIndex = 1;
            this.m_nexttri.Text = "1";
            // 
            // IDC_NEXTRR_BUTTON
            // 
            this.IDC_NEXTRR_BUTTON.Location = new System.Drawing.Point(91, 303);
            this.IDC_NEXTRR_BUTTON.Name = "IDC_NEXTRR_BUTTON";
            this.IDC_NEXTRR_BUTTON.Size = new System.Drawing.Size(107, 23);
            this.IDC_NEXTRR_BUTTON.TabIndex = 2;
            this.IDC_NEXTRR_BUTTON.Text = "Следующий";
            this.IDC_NEXTRR_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTRR_BUTTON.Click += new System.EventHandler(this.IDC_NEXTRR_BUTTON_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "n1+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "n1-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "n2+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "n2-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Коэф.";
            // 
            // m_nptri1
            // 
            this.m_nptri1.Location = new System.Drawing.Point(181, 55);
            this.m_nptri1.Name = "m_nptri1";
            this.m_nptri1.Size = new System.Drawing.Size(100, 23);
            this.m_nptri1.TabIndex = 8;
            this.m_nptri1.Text = "0";
            // 
            // m_nmtri1
            // 
            this.m_nmtri1.Location = new System.Drawing.Point(181, 90);
            this.m_nmtri1.Name = "m_nmtri1";
            this.m_nmtri1.Size = new System.Drawing.Size(100, 23);
            this.m_nmtri1.TabIndex = 9;
            this.m_nmtri1.Text = "0";
            // 
            // m_ztri
            // 
            this.m_ztri.Location = new System.Drawing.Point(181, 195);
            this.m_ztri.Name = "m_ztri";
            this.m_ztri.Size = new System.Drawing.Size(100, 23);
            this.m_ztri.TabIndex = 12;
            this.m_ztri.Text = "0";
            // 
            // m_nmtri2
            // 
            this.m_nmtri2.Location = new System.Drawing.Point(181, 160);
            this.m_nmtri2.Name = "m_nmtri2";
            this.m_nmtri2.Size = new System.Drawing.Size(100, 23);
            this.m_nmtri2.TabIndex = 11;
            this.m_nmtri2.Text = "0";
            // 
            // m_nptri2
            // 
            this.m_nptri2.Location = new System.Drawing.Point(181, 128);
            this.m_nptri2.Name = "m_nptri2";
            this.m_nptri2.Size = new System.Drawing.Size(100, 23);
            this.m_nptri2.TabIndex = 10;
            this.m_nptri2.Text = "0";
            // 
            // TRI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 338);
            this.Controls.Add(this.m_ztri);
            this.Controls.Add(this.m_nmtri2);
            this.Controls.Add(this.m_nptri2);
            this.Controls.Add(this.m_nmtri1);
            this.Controls.Add(this.m_nptri1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDC_NEXTRR_BUTTON);
            this.Controls.Add(this.m_nexttri);
            this.Controls.Add(this.label1);
            this.Name = "TRI";
            this.Text = "TRI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_nexttri;
        private System.Windows.Forms.Button IDC_NEXTRR_BUTTON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_nptri1;
        private System.Windows.Forms.TextBox m_nmtri1;
        private System.Windows.Forms.TextBox m_ztri;
        private System.Windows.Forms.TextBox m_nmtri2;
        private System.Windows.Forms.TextBox m_nptri2;
    }
}