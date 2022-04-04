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
    public partial class OU : Form
    {
        public OU()
        {
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nexteu.Text);
            GV.in_ou[i, 1] = Int32.Parse(m_npeu1.Text);
            GV.in_ou[i, 2] = Int32.Parse(m_nmeu1.Text);
            GV.in_ou[i, 3] = Int32.Parse(m_npeu2.Text);
            GV.in_ou[i, 4] = Int32.Parse(m_nmeu2.Text);
            /*
            GV.z_eu[i, 0] = Int32.Parse(m_zri.Text);
            GV.z_eu[i, 1] = Int32.Parse(m_zro.Text);
            GV.z_eu[i, 2] = Int32.Parse(m_zmu.Text);
            GV.z_eu[i, 3] = Int32.Parse(m_zft.Text);
            */
            GV.z_ou[i, 0] = float.Parse(m_zri.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            GV.z_ou[i, 1] = float.Parse(m_zro.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            GV.z_ou[i, 2] = float.Parse(m_zmu.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);
            GV.z_ou[i, 3] = float.Parse(m_zft.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture);

            i++;
            m_nexteu.Text = i.ToString();
            if (i <= GV.nou)
            {
                m_npeu1.Text = "0";
                m_nmeu1.Text = "0";
                m_npeu2.Text = "0";
                m_nmeu2.Text = "0";
                m_zri.Text = "0";
                m_zro.Text = "0";
                m_zmu.Text = "0";
                m_zft.Text = "0";
                m_npeu1.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}
