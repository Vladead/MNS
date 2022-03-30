using System;
using System.Globalization;
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
                    GV.f[1] = Convert.ToSingle(IDC_F1.Text, CultureInfo.InvariantCulture);
                    GV.nf = 1;
                    break;
                case 1:
                    fmin = GV.f[1] = Convert.ToSingle(IDC_F1.Text, CultureInfo.InvariantCulture);
                    fmax = Convert.ToSingle(IDC_F2.Text, CultureInfo.InvariantCulture);
                    df = Convert.ToSingle(IDC_F3.Text, CultureInfo.InvariantCulture);
                    kf = 1;
                    while (GV.f[kf] < fmax)
                    {
                        GV.f[kf + 1] = GV.f[kf] + df;
                        kf = kf + 1;
                    }

                    GV.nf = kf;
                    break;
                case 2:
                    GV.f[1] = Convert.ToSingle(IDC_F1.Text, CultureInfo.InvariantCulture);
                    fmax = Convert.ToSingle(IDC_F2.Text, CultureInfo.InvariantCulture);
                    kk = Convert.ToSingle(IDC_F3.Text, CultureInfo.InvariantCulture);
                    kf = 1;
                    while (GV.f[kf] < fmax)
                    {
                        GV.f[kf + 1] = kk * GV.f[kf];
                        kf = kf + 1;
                    }

                    GV.nf = kf;
                    break;
            }

            Close();
        }
    }
}