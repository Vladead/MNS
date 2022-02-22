using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (GlobalValues.nr > 0)
            {
                R ir = new R();
                ir.ShowDialog(this);
                ir.Dispose();
            }
            // Вызов диалоговой панели C
            if (GlobalValues.nc > 0)
            {
                C ir = new C();
                ir.ShowDialog(this);
                ir.Dispose();
            }
            // Вызов диалоговой панели L
            if (GlobalValues.nl > 0)
            {
                L ir = new L();
                ir.ShowDialog(this);
                ir.Dispose();
            }

            DialogResult res = MessageBox.Show("Выводить описание схемы в файл?",
                "Вывод в файл", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                FILE ofile = new FILE();
                GlobalValues.k = 0;
                ofile.ShowDialog(this);
                ofile.Dispose();
            }
            FormElement formElement = new FormElement();
            formElement.form_d(ref GlobalValues.in_r, GlobalValues.z_r, GlobalValues.nr, 'R');

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
            GlobalValues.k = 1;
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
            GlobalValues.flag = true;
        }

        private void ID_PRIV_Click(object sender, EventArgs e)
        {
            GlobalValues.flag = false;
        }

        private void ID_INTERNET_Click(object sender, EventArgs e)
        {
            if (!GlobalValues.flag)
            {
                INT cint = new INT();
                cint.Show(this);
            } else
            {
                System.Diagnostics.Process.Start("C:\\Program Files\\Mozilla Firefox\\firefox.exe", "http://127.0.0.1/MF/Int3d.htm");
            }
        }
    }
}
