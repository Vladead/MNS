using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS
{
    public partial class EU : Form
    {
        public EU()
        {
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            int i = int.Parse(m_nexteu.Text);
            GV.in_eu[i, 0] = int.Parse(m_npeu1.Text);
            GV.in_eu[i, 1] = int.Parse(m_nmeu1.Text);
            GV.in_eu[i, 2] = int.Parse(m_npeu2.Text);
            GV.in_eu[i, 3] = int.Parse(m_nmeu2.Text);
            
            GV.z_eu[i, 0] = int.Parse(m_zy0.Text);
            GV.z_eu[i, 1] = int.Parse(m_zt1.Text);
            GV.z_eu[i, 2] = int.Parse(m_zt2.Text);
            
            float.TryParse(m_zy0.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_eu[i, 0]);
            float.TryParse(m_zt1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_eu[i, 1]);
            float.TryParse(m_zt2.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_eu[i, 2]);

            i++;
            m_nexteu.Text = i.ToString();
            if (i <= GV.neu)
            {
                m_npeu1.Text = "0";
                m_nmeu1.Text = "0";
                m_npeu2.Text = "0";
                m_nmeu2.Text = "0";
                m_zy0.Text = "0";
                m_zt1.Text = "0";
                m_zt2.Text = "0";
                m_npeu1.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}
