using System;
using System.IO;
using System.Windows.Forms;

namespace KS
{
    public partial class FILE : Form
    {
        public FILE()
        {
            InitializeComponent();
        }

        private void IDC_FILEOK_BUTTON_Click(object sender, EventArgs e)
        {
            FileAction file = new FileAction();

            switch (GlobalValues.k)
            {
                case 0:
                    GlobalValues.filename = m_file.Text;
                    if (GlobalValues.filename != "")
                        file.fileout(GlobalValues.filename);
                    else
                        MessageBox.Show("Введите имя файла");
                    break;
                case 1:
                    GlobalValues.filename = m_file.Text;
                    try
                    {
                        file.filein(GlobalValues.filename);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    break;
            }
            this.Close();
        }
    }

    public partial class FileAction : Form
    {
        public void fileout(String filename)      //Вывод описания схемы в файл
        {
            StreamWriter fout = new StreamWriter(GlobalValues.filename);
            String str = "";
            int i;
            str = GlobalValues.nv.ToString() + " " + GlobalValues.nr.ToString() + " " + GlobalValues.nc.ToString() + " " + GlobalValues.nl.ToString();

            fout.WriteLine(str);
            for (i = 1; i <= GlobalValues.nr; i++)
            {
                str = GlobalValues.in_r[i, 0].ToString() + " " + GlobalValues.in_r[i, 1].ToString() + " "
                    + GlobalValues.z_r[i].ToString();
                fout.WriteLine(str);
            }
            for (i = 1; i <= GlobalValues.nc; i++)
            {
                str = GlobalValues.in_c[i, 0].ToString() + " " + GlobalValues.in_c[i, 1].ToString() + " "
                    + GlobalValues.z_c[i].ToString();
                fout.WriteLine(str);
            }
            for (i = 1; i <= GlobalValues.nl; i++)
            {
                str = GlobalValues.in_l[i, 0].ToString() + " " + GlobalValues.in_l[i, 1].ToString() + " "
                    + GlobalValues.z_l[i].ToString();
                fout.WriteLine(str);

            }
            //...
            fout.Close();
        }

        public void filein(String filename)      //Ввод описания схемы из файла
        {
            StreamReader fin = new StreamReader(GlobalValues.filename);
            char[] sep = { ' ' };
            string str = "";
            str = fin.ReadLine();
            String[] s = str.Split(sep, 4);//Значение второго аргумента!!!
            GlobalValues.nv = Int32.Parse(s[0]);
            GlobalValues.nr = Int32.Parse(s[1]);
            GlobalValues.nc = Int32.Parse(s[2]);
            GlobalValues.nl = Int32.Parse(s[3]);

            for (int i = 1; i <= GlobalValues.nr; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                GlobalValues.in_r[i, 0] = Int32.Parse(s[0]);
                GlobalValues.in_r[i, 1] = Int32.Parse(s[1]);
                GlobalValues.z_r[i] = Single.Parse(s[2]);
            }
            for (int i = 1; i <= GlobalValues.nc; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                GlobalValues.in_c[i, 0] = Int32.Parse(s[0]);
                GlobalValues.in_c[i, 1] = Int32.Parse(s[1]);
                GlobalValues.z_c[i] = Single.Parse(s[2]);
            }
            for (int i = 1; i <= GlobalValues.nl; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                GlobalValues.in_l[i, 0] = Int32.Parse(s[0]);
                GlobalValues.in_l[i, 1] = Int32.Parse(s[1]);
                GlobalValues.z_l[i] = Single.Parse(s[2]);
            }

            fin.Close();
        }
    }
}
