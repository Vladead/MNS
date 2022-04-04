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
            GV.nv = Int32.Parse(m_nv.Text);
            GV.nr = Int32.Parse(m_nr.Text);
            GV.nc = Int32.Parse(m_nc.Text);
            GV.nl = Int32.Parse(m_nl.Text);
            GV.nju = Int32.Parse(m_ju.Text);
            GV.nei = Int32.Parse(m_ei.Text);
            GV.nji = Int32.Parse(m_ji.Text);
            GV.ntri = Int32.Parse(m_tri.Text);
            GV.neu = Int32.Parse(m_eu.Text);
            GV.nou = Int32.Parse(m_nou.Text);
            Close();
        }
    }
}
