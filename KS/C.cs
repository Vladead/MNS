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
    public partial class C : Form
    {
        public C()
        {
            InitializeComponent();
        }

        private void IDC_NEXTC_BUTTON_Click(object sender, EventArgs e)
        {
            int i = int.Parse(m_nextC.Text);
            GlobalValues.in_c[i, 0] = Convert.ToInt32(m_npc.Text, CultureInfo.InvariantCulture);
            GlobalValues.in_c[i, 1] = Convert.ToInt32(m_nmc.Text, CultureInfo.InvariantCulture);
            GlobalValues.z_c[i] = Convert.ToSingle(m_zc.Text, CultureInfo.InvariantCulture);
            i++;
            m_nextC.Text = i.ToString();
            if (i <= GlobalValues.nc)
            {
                m_npc.Text = "0";
                m_nmc.Text = "0";
                m_zc.Text = "0";
                m_npc.Focus();
            }
            else
                Close();
        }
    }
}