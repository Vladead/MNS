using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KS
{
    public partial class SizeDialog : Form
    {
        public SizeDialog()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            GlobalValues.nv = Int32.Parse(m_nv.Text);
            GlobalValues.nr = Int32.Parse(m_nr.Text);
            //GlobalValues.nc = Int32.Parse(m_nc.Text);
            //GlobalValues.nl = Int32.Parse(m_nl.Text);
            Close();
        }
    }
}
