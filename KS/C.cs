using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KS
{
    public partial class C : Form
    {
        public C()
        {
            InitializeComponent();
        }

        private void IDC_NEXTC_BUTTON_Click(object sender, EventArgs e)
        {
            int i = int.Parse(m_nextC.Text);
            GlobalValues.in_r[i, 0] = int.Parse(m_npc.Text);
            GlobalValues.in_r[i, 1] = int.Parse(m_nmc.Text);
            GlobalValues.z_r[i] = float.Parse(m_zc.Text);
            i++;
            m_nextC.Text = i.ToString();
            if (i <= GlobalValues.nr)
            {
                m_npc.Text = "0";
                m_nmc.Text = "0";
                m_zc.Text = "0";
                m_npc.Focus();
            }
            else
                Close();
        }
    }
}
