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
    public partial class JU : Form
    {
        public JU()
        {
            InitializeComponent();
        }

        private void IDC_NEXTJU_BUTTON_Click(object sender, EventArgs e)
        {
            int i = int.Parse(m_nextju.Text);
            GV.in_ju[i, 0] = int.Parse(m_npju1.Text);
            GV.in_ju[i, 1] = int.Parse(m_nmju1.Text);
            GV.in_ju[i, 2] = int.Parse(m_npju2.Text);
            GV.in_ju[i, 3] = int.Parse(m_nmju2.Text);

            GV.z_ju[i, 0] = int.Parse(m_zy0.Text);
            GV.z_ju[i, 1] = int.Parse(m_zt1.Text);
            GV.z_ju[i, 2] = int.Parse(m_zt2.Text);

            float.TryParse(m_zy0.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_eu[i, 0]);
            float.TryParse(m_zt1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_eu[i, 1]);
            float.TryParse(m_zt2.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_eu[i, 2]);

            i++;
            m_nextju.Text = i.ToString();
            if (i <= GV.nju)
            {
                m_npju1.Text = "0";
                m_nmju1.Text = "0";
                m_npju2.Text = "0";
                m_nmju2.Text = "0";
                m_zy0.Text = "0";
                m_zt1.Text = "0";
                m_zt2.Text = "0";
                m_npju1.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}
