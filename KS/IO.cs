using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KS
{
    public partial class IO : Form
    {
        public IO()
        {
            InitializeComponent();
        }

        private void IDC_IOOK_BUTTON_Click(object sender, EventArgs e)
        {
            GlobalValues.lp = Int32.Parse(m_lp.Text);
            GlobalValues.lm = Int32.Parse(m_lm.Text);
            GlobalValues.kp = Int32.Parse(m_kp.Text);
            GlobalValues.km = Int32.Parse(m_km.Text);
            this.Close();

        }
    }
}
