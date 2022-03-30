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
    public partial class JI : Form
    {
        public JI()
        {
            InitializeComponent();
        }

        private void IDC_NEXTJI_BUTTON_Click(object sender, EventArgs e)
        {
            int i = int.Parse(m_nextji.Text);
            GV.in_ji[i, 0] = int.Parse(m_npji1.Text);
            GV.in_ji[i, 1] = int.Parse(m_nmji1.Text);
            GV.in_ji[i, 2] = int.Parse(m_npji2.Text);
            GV.in_ji[i, 3] = int.Parse(m_nmji2.Text);

            GV.z_ji[i, 0] = int.Parse(m_zy0.Text);
            GV.z_ji[i, 1] = int.Parse(m_zt1.Text);
            GV.z_ji[i, 2] = int.Parse(m_zt2.Text);

            float.TryParse(m_zy0.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_eu[i, 0]);
            float.TryParse(m_zt1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_eu[i, 1]);
            float.TryParse(m_zt2.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_eu[i, 2]);

            i++;
            m_nextji.Text = i.ToString();
            if (i <= GV.nju)
            {
                m_npji1.Text = "0";
                m_nmji1.Text = "0";
                m_npji2.Text = "0";
                m_nmji2.Text = "0";
                m_zy0.Text = "0";
                m_zt1.Text = "0";
                m_zt2.Text = "0";
                m_npji1.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}
