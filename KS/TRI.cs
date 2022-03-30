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
    public partial class TRI : Form
    {
        public TRI()
        {
            InitializeComponent();
        }

        private void IDC_NEXTRR_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nexttri.Text);

            GV.in_tri[i, 0] = Int32.Parse(m_nptri1.Text);
            GV.in_tri[i, 1] = Int32.Parse(m_nmtri1.Text);
            GV.in_tri[i, 2] = Int32.Parse(m_nptri2.Text);
            GV.in_tri[i, 3] = Int32.Parse(m_nmtri2.Text);
            GV.z_tri[i] = Int32.Parse(m_ztri.Text);
            float.TryParse(m_ztri.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_ei[i]);

            i++;
            m_nexttri.Text = i.ToString();
            if (i <= GV.nei)
            {
                m_nptri1.Text = "0";
                m_nmtri1.Text = "0";
                m_nptri2.Text = "0";
                m_nmtri2.Text = "0";
                m_ztri.Text = "0";
                m_nptri1.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}
