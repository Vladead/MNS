using System;
using System.Windows.Forms;

namespace KS
{
    public partial class KsDlg : Form
    {
        public KsDlg()
        {
            InitializeComponent();
        }

        private void ID_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ID_CONS_Click(object sender, EventArgs e)
        {
            // Вызов диалоговой панели размерности схемы
            SizeDialog size = new SizeDialog();
            size.ShowDialog(this);
            size.Dispose();
            // Вызов диалоговой панели R
            if (GV.nr > 0)
            {
                R ir = new R();
                ir.ShowDialog(this);
                ir.Dispose();
            }
            // Вызов диалоговой панели C
            if (GV.nc > 0)
            {
                C ir = new C();
                ir.ShowDialog(this);
                ir.Dispose();
            }
            // Вызов диалоговой панели L
            if (GV.nl > 0)
            {
                L ir = new L();
                ir.ShowDialog(this);
                ir.Dispose();
            }
            if (GV.nei > 0)
            {
                EI ei = new EI();
                ei.ShowDialog(this);
                ei.Dispose();
            }
            if (GV.nju > 0)
            {
                JU ju = new JU();
                ju.ShowDialog(this);
                ju.Dispose();
            }
            if (GV.nji > 0)
            {
                JI ji = new JI();
                ji.ShowDialog(this);
                ji.Dispose();
            }
            if (GV.ntri > 0)
            {
                TRI tri = new TRI();
                tri.ShowDialog(this);
                tri.Dispose();
            }
            if (GV.neu > 0)
            {
                EU eu = new EU();
                eu.ShowDialog(this);
                eu.Dispose();
            }

            DialogResult res = MessageBox.Show("Выводить описание схемы в файл?",
                "Вывод в файл", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                FILE ofile = new FILE();
                GV.k = 0;
                ofile.ShowDialog(this);
                ofile.Dispose();
            }

            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_RED_Click(object sender, EventArgs e)
        {
            RED red = new RED();
            red.ShowDialog(this);
            red.Dispose();
        }

        private void ID_FILE_Click(object sender, EventArgs e)
        {
            GV.k = 1;
            FILE file = new FILE();
            try
            {
                file.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            file.Dispose();
            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_F_Click(object sender, EventArgs e)
        {
            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
        }

        private void ID_IO_Click(object sender, EventArgs e)
        {
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_SYS_Click(object sender, EventArgs e)
        {
            GV.flag = true;
        }

        private void ID_PRIV_Click(object sender, EventArgs e)
        {
            GV.flag = false;
        }

        private void ID_INTERNET_Click(object sender, EventArgs e)
        {
            if (!GV.flag)
            {
                INT cint = new INT();
                cint.Show(this);
            }
            else
            {
                System.Diagnostics.Process.Start("C:\\Program Files\\Mozilla Firefox\\firefox.exe", "http://127.0.0.1/MF/Int3d.htm");
            }
        }

        private void ID_CALC_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= GV.M; i++)
                //Обнуление массивов a и b
                for (int j = 0; j <= GV.M; j++)
                {
                    GV.a[i, j] = 0;
                    GV.b[i, j] = 0;
                }
            GV.n = GV.nv;
            for (int kf = 1; kf <= GV.nf; kf++)
            {
                GV.om = (float)(2 * 3.141593 * GV.f[kf]);
                FormElement.form1_d(ref GV.in_r, ref GV.z_r, GV.nr, 'R');
                FormElement.form1_d(ref GV.in_c, ref GV.z_c, GV.nc, 'C');
                FormElement.form1_d(ref GV.in_l, ref GV.z_l, GV.nl, 'L');
                FormElement.form_ei();
                FormElement.form_eu();
                FormElement.form_tri();
                
                //…
                FormElement.form_w();
                
                if ((GV.lp == 1) && (GV.lm == 0) && (GV.kp == 2) && (GV.km == 0))
                {
                    SF.st();
                    SF.sf1(kf);
                }
                else
                {
                    SF.gauss_c();
                    SF.sf2(kf);
                }
                //…
            }

            string str = "";
            str = "Результаты моделирования ";
            richTextBox1.AppendText(str + "\r\n");
            if ((GV.lp == 1) && (GV.lm == 0) && (GV.kp == 2) && (GV.km == 0))
            {
                str = String.Format("{0,-12}{1,-12}{2,-12}{3,-12}{4,-12}{5,-12}{6,-12}", "f кГц", "kum", "kua", "rim", "ria", "rom", "roa");
                richTextBox1.AppendText(str + "\r\n");
                for (int kf = 1; kf <= GV.nf; kf++)
                {
                    str = String.Format("{0,-12:F2}{1,-12:E2}{2,-12:F2}{3,-12:E2}{4,-12:F2}{5,-12:E2}{6,-12:F2}",
                    GV.f[kf], GV.kum[kf], GV.kua[kf], GV.rim[kf],
                    GV.ria[kf], GV.rom[kf], GV.roa[kf]);
                    richTextBox1.AppendText(str + "\r\n");
                }
            }
            else
            {
                str = String.Format("{0,-12}{1,-12}{2,-12}{3,-12}{4,-12}", "f кГц", "kum", "kua", "rim", "ria");
                richTextBox1.AppendText(str + "\r\n");
                for (int kf = 1; kf <= GV.nf; kf++)
                {
                    str = String.Format("{0,-12:F2}{1,-12:E2}{2,-12:F2}{3,-12:E2}{4,-12:F2}",
                    GV.f[kf], GV.kum[kf], GV.kua[kf], GV.rim[kf], GV.ria[kf]);
                    richTextBox1.AppendText(str + "\r\n");
                }
            }
        }
    }
}
