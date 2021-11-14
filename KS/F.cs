using System;
using System.Windows.Forms;

namespace KS
{
    public partial class F : Form
    {
        int m_f = 0;

        public F()
        {
            InitializeComponent();
        }

        private void IDC_F_CheckedChanged(object sender, EventArgs e)
        {
            IDC_F1.Focus();
            m_f = 0;
            IDC_T1.Text = "Значение частоты (КГц)";
            IDC_T2.Text = "";
            IDC_T3.Text = "";
        }

        private void IDC_DF_CheckedChanged(object sender, EventArgs e)
        {
            IDC_F1.Focus();
            m_f = 1;
            IDC_T1.Text = "Минимальная частота Fmin(КГц)";
            IDC_T2.Text = "Максимальная частота Fmax(КГц)";
            IDC_T3.Text = "Шаг изменения частоты dF(КГц)";
        }

        private void IDC_KF_CheckedChanged(object sender, EventArgs e)
        {
            IDC_F1.Focus();
            m_f = 2;
            IDC_T1.Text = "Минимальная частота Fmin(КГц)";
            IDC_T2.Text = "Максимальная частота Fmax(КГц)";
            IDC_T3.Text = "Отношение соседних частот К";
        }

        private void IDC_FOK_BUTTON_Click(object sender, EventArgs e)
        {
            float fmin, fmax, df, kk;
            int kf;
            switch (m_f)
            {
                case 0:
                    GlobalValues.f[1] = Single.Parse(IDC_F1.Text);
                    GlobalValues.nf = 1;
                    break;
                case 1:
                    fmin = GlobalValues.f[1] = Single.Parse(IDC_F1.Text);
                    fmax = Single.Parse(IDC_F2.Text);
                    df = Single.Parse(IDC_F3.Text);
                    kf = 1;
                    while (GlobalValues.f[kf] < fmax)
                    {
                        GlobalValues.f[kf + 1] = GlobalValues.f[kf] + df;
                        kf = kf + 1;
                    }
                    GlobalValues.nf = kf;
                    break;
                case 2:
                    GlobalValues.f[1] = Single.Parse(IDC_F1.Text);
                    fmax = Single.Parse(IDC_F2.Text);
                    kk = Single.Parse(IDC_F3.Text);
                    kf = 1;
                    while (GlobalValues.f[kf] < fmax)
                    {
                        GlobalValues.f[kf + 1] = kk * GlobalValues.f[kf];
                        kf = kf + 1;
                    }
                    GlobalValues.nf = kf;
                    break;
            }
            this.Close();

        }
    }
}

