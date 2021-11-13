using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KS
{
    public partial class L : Form
    {
        public L()
        {
            InitializeComponent();
        }

        private void IDC_NEXTL_BUTTON_Click(object sender, EventArgs e)
        {
            int i = int.Parse(m_nextL.Text);
            GlobalValues.in_l[i, 0] = int.Parse(m_npl.Text);
            GlobalValues.in_l[i, 1] = int.Parse(m_nml.Text);
            GlobalValues.z_l[i] = float.Parse(m_zl.Text);
            i++;
            m_nextL.Text = i.ToString();
            if (i <= GlobalValues.nl)
            {
                m_npl.Text = "0";
                m_nml.Text = "0";
                m_zl.Text = "0";
                m_npl.Focus();
            }
            else
                Close();
        }
    }
}
