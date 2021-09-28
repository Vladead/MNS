
namespace KS
{
    partial class C
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
            this.IDC_NEXTC_BUTTON = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.m_zc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_nmc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_npc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_nextC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IDC_NEXTC_BUTTON
            // 
            this.IDC_NEXTC_BUTTON.Location = new System.Drawing.Point(95, 149);
            this.IDC_NEXTC_BUTTON.Name = "IDC_NEXTC_BUTTON";
            this.IDC_NEXTC_BUTTON.Size = new System.Drawing.Size(101, 23);
            this.IDC_NEXTC_BUTTON.TabIndex = 17;
            this.IDC_NEXTC_BUTTON.Text = "Следующий";
            this.IDC_NEXTC_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTC_BUTTON.Click += new System.EventHandler(this.IDC_NEXTC_BUTTON_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Емкость (мкФ)";
            // 
            // m_zc
            // 
            this.m_zc.Location = new System.Drawing.Point(148, 93);
            this.m_zc.Name = "m_zc";
            this.m_zc.Size = new System.Drawing.Size(100, 23);
            this.m_zc.TabIndex = 15;
            this.m_zc.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Узел n-";
            // 
            // m_nmc
            // 
            this.m_nmc.Location = new System.Drawing.Point(148, 64);
            this.m_nmc.Name = "m_nmc";
            this.m_nmc.Size = new System.Drawing.Size(100, 23);
            this.m_nmc.TabIndex = 13;
            this.m_nmc.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Узел n+";
            // 
            // m_npc
            // 
            this.m_npc.Location = new System.Drawing.Point(148, 35);
            this.m_npc.Name = "m_npc";
            this.m_npc.Size = new System.Drawing.Size(100, 23);
            this.m_npc.TabIndex = 11;
            this.m_npc.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Конденсатор C";
            // 
            // m_nextC
            // 
            this.m_nextC.Location = new System.Drawing.Point(148, 6);
            this.m_nextC.Name = "m_nextC";
            this.m_nextC.ReadOnly = true;
            this.m_nextC.Size = new System.Drawing.Size(100, 23);
            this.m_nextC.TabIndex = 9;
            this.m_nextC.Text = "1";
            // 
            // C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 234);
            this.Controls.Add(this.IDC_NEXTC_BUTTON);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_zc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_nmc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_npc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_nextC);
            this.Name = "C";
            this.Text = "C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDC_NEXTC_BUTTON;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_zc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_nmc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_npc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_nextC;
    }
}