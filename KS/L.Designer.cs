
namespace KS
{
    partial class L
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
            this.IDC_NEXTL_BUTTON = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.m_zl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_nml = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_npl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_nextL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDC_NEXTL_BUTTON
            // 
            this.IDC_NEXTL_BUTTON.Location = new System.Drawing.Point(95, 149);
            this.IDC_NEXTL_BUTTON.Name = "IDC_NEXTL_BUTTON";
            this.IDC_NEXTL_BUTTON.Size = new System.Drawing.Size(101, 23);
            this.IDC_NEXTL_BUTTON.TabIndex = 26;
            this.IDC_NEXTL_BUTTON.Text = "Следующий";
            this.IDC_NEXTL_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTL_BUTTON.Click += new System.EventHandler(this.IDC_NEXTL_BUTTON_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Индуктивность (Гн)";
            // 
            // m_zl
            // 
            this.m_zl.Location = new System.Drawing.Point(148, 93);
            this.m_zl.Name = "m_zl";
            this.m_zl.Size = new System.Drawing.Size(100, 23);
            this.m_zl.TabIndex = 24;
            this.m_zl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Узел n-";
            // 
            // m_nml
            // 
            this.m_nml.Location = new System.Drawing.Point(148, 64);
            this.m_nml.Name = "m_nml";
            this.m_nml.Size = new System.Drawing.Size(100, 23);
            this.m_nml.TabIndex = 22;
            this.m_nml.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Узел n+";
            // 
            // m_npl
            // 
            this.m_npl.Location = new System.Drawing.Point(148, 35);
            this.m_npl.Name = "m_npl";
            this.m_npl.Size = new System.Drawing.Size(100, 23);
            this.m_npl.TabIndex = 20;
            this.m_npl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Индуктивность L";
            // 
            // m_nextL
            // 
            this.m_nextL.Location = new System.Drawing.Point(148, 6);
            this.m_nextL.Name = "m_nextL";
            this.m_nextL.ReadOnly = true;
            this.m_nextL.Size = new System.Drawing.Size(100, 23);
            this.m_nextL.TabIndex = 18;
            this.m_nextL.Text = "1";
            // 
            // L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 253);
            this.Controls.Add(this.IDC_NEXTL_BUTTON);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_zl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_nml);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_npl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_nextL);
            this.Name = "L";
            this.Text = "L";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDC_NEXTL_BUTTON;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_zl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_nml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_npl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_nextL;
    }
}