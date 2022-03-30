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
    public partial class EI : Form
    {
        public EI()
        {
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextei.Text);

            GV.in_ei[i, 0] = Int32.Parse(m_npei1.Text);
            GV.in_ei[i, 1] = Int32.Parse(m_nmei1.Text);
            GV.in_ei[i, 2] = Int32.Parse(m_npei2.Text);
            GV.in_ei[i, 3] = Int32.Parse(m_nmei2.Text);
            GV.z_ei[i] = Int32.Parse(m_zei.Text);
            float.TryParse(m_zei.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_ei[i]);

            i++;
            m_nextei.Text = i.ToString();
            if (i <= GV.nei)
            {
                m_npei1.Text = "0";
                m_nmei1.Text = "0";
                m_npei2.Text = "0";
                m_nmei2.Text = "0";
                m_zei.Text = "0";
                m_npei1.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}
