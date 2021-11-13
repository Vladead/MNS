using System;
using System.Windows.Forms;

namespace KS
{
    public partial class RED : Form
    {
        public RED()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_redlst_DoubleClick(object sender, EventArgs e)
        {
            String i1, i2, i3, i4, i5, i6, i7, i8, i9;
            //Начальная установка
            m_np1.Show();
            m_nm1.Show();
            m_np2.Show();
            m_nm2.Show();
            m_z1.Show();
            m_z2.Show();
            m_z3.Show();
            m_z4.Show();
            m_z5.Show();
            m_z6.Show();
            IDC_NP1_STATIC.Show();
            IDC_NM1_STATIC.Show();
            IDC_NP2_STATIC.Show();
            IDC_NM2_STATIC.Show();
            IDC_Z1_STATIC.Show();
            IDC_Z2_STATIC.Show();
            IDC_Z3_STATIC.Show();
            IDC_Z4_STATIC.Show();
            IDC_Z5_STATIC.Show();
            IDC_Z6_STATIC.Show();
            m_np1.Text = "";
            m_nm1.Text = "";
            m_np2.Text = "";
            m_nm2.Text = "";
            m_z1.Text = "";
            m_z2.Text = "";
            m_z3.Text = "";
            m_z4.Text = "";
            m_z5.Text = "";
            m_z6.Text = "";
            //Выбор типа компонента из списка и настройка панели
            int idx = m_redlst.SelectedIndex;
            switch (idx)
            {
                case 0:
                case 1:
                case 2:
                    i1 = "n+";
                    i2 = "n-";
                    i3 = "Значение";
                    IDC_NP2_STATIC.Text = i1;
                    IDC_NM2_STATIC.Text = i2;
                    IDC_Z1_STATIC.Text = i3;
                    m_np1.Hide();
                    m_nm1.Hide();
                    m_z2.Hide();
                    m_z3.Hide();
                    m_z4.Hide();
                    m_z5.Hide();
                    m_z6.Hide();
                    IDC_NP1_STATIC.Hide();
                    IDC_NM1_STATIC.Hide();
                    IDC_Z2_STATIC.Hide();
                    IDC_Z3_STATIC.Hide();
                    IDC_Z4_STATIC.Hide();
                    IDC_Z5_STATIC.Hide();
                    IDC_Z6_STATIC.Hide();
                    m_n.Focus();
                    break;
                    // …..
            }

        }

        private void IDC_OUT_BUTTON_Click(object sender, EventArgs e)
        {
            int idx = m_redlst.SelectedIndex;
            GlobalValues.k = Int32.Parse(m_n.Text);
            switch (idx)
            {
                case 0:
                    m_np2.Text = GlobalValues.in_r[GlobalValues.k, 0].ToString();
                    m_nm2.Text = GlobalValues.in_r[GlobalValues.k, 1].ToString();
                    m_z1.Text = GlobalValues.z_r[GlobalValues.k].ToString();
                    break;
                    //...
                    OK.Focus();
            }

        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
