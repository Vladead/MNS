using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            GV.in_l[i, 0] = Convert.ToInt32(m_npl.Text, CultureInfo.InvariantCulture);
            GV.in_l[i, 1] = Convert.ToInt32(m_nml.Text, CultureInfo.InvariantCulture);
            GV.z_l[i] = Convert.ToSingle(m_zl.Text, CultureInfo.InvariantCulture);
            i++;
            m_nextL.Text = i.ToString();
            if (i <= GV.nl)
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