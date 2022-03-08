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
    public partial class R : Form
    {
        public R()
        {
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            int i = int.Parse(m_nextR.Text);
            GlobalValues.in_r[i, 0] = Convert.ToInt32(m_npr.Text, CultureInfo.InvariantCulture);
            GlobalValues.in_r[i, 1] = Convert.ToInt32(m_nmr.Text, CultureInfo.InvariantCulture);
            GlobalValues.z_r[i] = Convert.ToSingle(m_zr.Text, CultureInfo.InvariantCulture);
            i++;
            m_nextR.Text = i.ToString();
            if (i <= GlobalValues.nr)
            {
                m_npr.Text = "0";
                m_nmr.Text = "0";
                m_zr.Text = "0";
                m_npr.Focus();
            }
            else
                Close();
        }
    }
}
