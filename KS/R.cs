using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KS
{
    public partial class R : Form
    {
        public R()
        {
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            int i = int.Parse(m_nextR.Text);
            GlobalValues.in_r[i, 0] = int.Parse(m_npr.Text);
            GlobalValues.in_r[i, 1] = int.Parse(m_nmr.Text);
            GlobalValues.z_r[i] = Convert.ToSingle(m_zr.Text);
            i++;
            m_nextR.Text = i.ToString();
            if (i <= GlobalValues.nr)
            {
                m_npr.Text = "0";
                m_nmr.Text = "0";
                m_zr.Text = "0";
                m_npr.Focus();
            }
            else
            {
                form_r();
                Close();
            }
        }

        private void form_r()
        {
            int i, j, g;
            float[,] w = new float[GlobalValues.nv, GlobalValues.nv];
            StreamWriter sr = new StreamWriter("C:\\Users\\vlade\\Downloads\\Output.txt");
            sr.Write("kr l i m j g w[i,j] \n");
            for (int kr = 1; kr <= GlobalValues.nr; kr++)
                for (int l = 0; l <= 1; l++)
                {
                    i = GlobalValues.in_r[kr, l];
                    if (i == 0) continue;
                    for (int m = 0; m <= 1; m++)
                    {
                        j = GlobalValues.in_r[kr, m];
                        if (j == 0) continue;
                        g = (1 - 2 * l) * (1 - 2 * m);
                        w[i, j] += g / GlobalValues.z_r[kr];
                        sr.Write($"{kr}  {l}  {i}  {m}  {j}   {g}   {w[i, j]} \n");
                    }
                }
            sr.Write("in_r \n");
            //foreach (var temp1 in GlobalValues.in_r)
            //{
            //    sr.WriteLine(temp1);
            //}
            for (int k = 0; k < GlobalValues.MR + 1; k++)
            {
                for (int p = 0; p < 2; p++)
                {
                    sr.Write(GlobalValues.in_r[k, p] + " ");
                }
                sr.Write("\n");
            }
            sr.Write("\n z_r \n");
            //foreach (var temp1 in GlobalValues.z_r)
            //{
            //    sr.WriteLine(temp1);
            //}
            for (int k = 0; k < GlobalValues.MR + 1; k++)
            {
                
                sr.Write(GlobalValues.z_r[k] + " ");
                
            }
            sr.Write("\n w \n");
            //foreach (var temp1 in w)
            //{
            //    sr.WriteLine(temp1);
            //}
            for (int k = 0; k < GlobalValues.nv; k++)
            {
                for (int p = 0; p < GlobalValues.nv; p++)
                {
                    sr.Write(w[k, p] + " ");
                }
                sr.Write("\n");
            }
            sr.Close();
        }
    }
}
