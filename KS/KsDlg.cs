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

        private void ID_PRIV_Click(object sender, EventArgs e)
        {

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
        }

        private void ID_RED_Click(object sender, EventArgs e)
        {
            RED red = new RED();
            red.ShowDialog(this);
            red.Dispose();
        }
    }
}
