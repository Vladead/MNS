using System;
using System.IO;
using System.Windows.Forms;
using FRQVS;

namespace KS
{
    public class SF
    {
        public static void st()
        {
            Complex c = new Complex(0, 0);
            Complex t = new Complex(0, 0);
            Complex cn = new Complex(0, 0);
            double g;
            int l;

            for (int k = GV.n; k >= 3; k--)
            {
                l = k;
                g = 0.001;
                while (GV.w[l, k].abs <= g)
                {
                    l--;
                    if (l == 2)
                    {
                        l = k;
                        g = 0.1 * g;
                    }
                }
                if (l != k)
                {
                    for (int j = k; j <= GV.n; j++)
                    {
                        t = GV.w[k, j];
                        GV.w[k, j] = GV.w[l, j];
                        GV.w[l, j] = t;
                    }
                }
                for (int i = k - 1; i >= 1; i--)
                {
                    if (GV.w[i, k] == cn) continue;
                    c = GV.w[i, k] / GV.w[k, k];
                    for (int j = 1; j <= k - 1; j++)
                    {
                        if (GV.w[k, j] != cn)
                        {
                            GV.w[i, j] += c * GV.w[k, j];
                        }
                    }

                }
            }
        }

        public static void sf1(int kf)
        {
            Complex ku = -GV.w[2, 1] / GV.w[2, 2];
            Complex d = GV.w[1, 1] * GV.w[2, 2] - GV.w[2, 1] * GV.w[1, 2];
            Complex ri = GV.w[2, 2] / d;
            Complex ro = GV.w[1, 1] / d;
            GV.kum[kf] = (float)ku.abs;
            GV.kua[kf] = (float)ku.arg * 180.0f / (float)Math.PI;
            GV.rim[kf] = (float)ri.abs;
            GV.ria[kf] = (float)ri.arg * 180.0f / (float)Math.PI;
            GV.rom[kf] = (float)ro.abs;
            GV.roa[kf] = (float)ro.arg * 180.0f / (float)Math.PI;
        }

        public static void gauss_c()
        {
            int i, j, k, l;
            Complex c = new Complex(0, 0);
            Complex d = new Complex(0, 0);
            Complex t = new Complex(0, 0);
            Complex cn = new Complex(0, 0);
            for (k = 1; k < GV.n; k++)
            {
                l = k;
                for (i = k + 1; i <= GV.n; i++)
                    if (GV.w[i, k].abs > GV.w[l, k].abs)
                        l = i;

                if (l != k)
                    for (j = 0; j <= GV.n; j++)
                        if (j == 0 || j >= k)
                        {
                            t = GV.w[k, j];
                            GV.w[k, j] = GV.w[l, j];
                            GV.w[l, j] = t;
                        }
                d = 1.0 / GV.w[k, k];
                for (i = k + 1; i <= GV.n; i++)
                {
                    if (GV.w[i, k] == cn)
                        continue;
                    c = GV.w[i, k] * d;
                    for (j = k + 1; j <= GV.n; j++)
                        if (GV.w[k, j] != cn)
                            GV.w[i, j] = GV.w[i, j] - c * GV.w[k, j];
                    if (GV.w[k, 0] != cn)
                        GV.w[i, 0] = GV.w[i, 0] - c * GV.w[k, 0];
                }
            }
            GV.w[0, GV.n] = -GV.w[GV.n, 0] / GV.w[GV.n, GV.n];
            for (i = GV.n - 1; i >= 1; i--)
            {
                t = GV.w[i, 0];
                for (j = i + 1; j <= GV.n; j++)
                    t = t + GV.w[i, j] * GV.w[0, j];
                GV.w[0, i] = -t / GV.w[i, i];
            }
        }

        public static void sf2(int kf)
        {
            Complex ku = new Complex(0, 0);
            Complex ri = new Complex(0, 0);
            ri = GV.w[0, GV.lp] - GV.w[0, GV.lm];
            ku = (GV.w[0, GV.kp] - GV.w[0, GV.km]) / ri;
            GV.kum[kf] = (float)ku.abs;
            GV.kua[kf] = (float)ku.arg * 180.0f / (float)Math.PI;
            GV.rim[kf] = (float)ri.abs;
            GV.ria[kf] = (float)ri.arg * 180.0f / (float)Math.PI;
        }

        public static void write_out()
        {
            StreamWriter fout = new StreamWriter("PR.txt");
            fout.WriteLine(DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." +
                DateTime.Now.Year.ToString() + "  " + DateTime.Now.Hour.ToString() + ":" +
                DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString());
            fout.WriteLine("Описание компонентов");
            //Описание резисторов
            if (GV.nr != 0)
            {
                fout.WriteLine("Резисторы");
                fout.WriteLine("\t\tn+\t\tn-\t\tR(КОм)");
                for (int i = 1; i <= GV.nr; i++)
                {
                    fout.WriteLine("R{0}\t\t{1}\t\t{2}\t\t{3}",
                    i, GV.in_r[i, 0], GV.in_r[i, 1], GV.z_r[i]);
                }
            }
            if (GV.nc != 0)
            {
                fout.WriteLine("Конденсаторы");
                fout.WriteLine("\t\tn+\t\tn-\t\tC(КФ)");
                for (int i = 1; i <= GV.nc; i++)
                {
                    fout.WriteLine("C{0}\t\t{1}\t\t{2}\t\t{3}",
                    i, GV.in_c[i, 0], GV.in_c[i, 1], GV.z_c[i]);
                }
            }
            if (GV.nl != 0)
            {
                fout.WriteLine("Индуктивности");
                fout.WriteLine("\t\tn+\t\tn-\t\tL(КГн)");
                for (int i = 1; i <= GV.nl; i++)
                {
                    fout.WriteLine("L{0}\t\t{1}\t\t{2}\t\t{3}",
                    i, GV.in_l[i, 0], GV.in_l[i, 1], GV.z_l[i]);
                }
            }
            if (GV.neu != 0)
            {
                fout.WriteLine("ИНУН");
                fout.WriteLine("\t\tn1+\t\tn1-\t\tn2+\t\tn2-\t\ty0\t\tT1\t\tT2");
                for (int i = 1; i <= GV.neu; i++)
                {
                    fout.WriteLine("EU{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t\t{6}\t\t{7}",
                    i, GV.in_eu[i, 0], GV.in_eu[i, 1], GV.in_eu[i, 2], GV.in_eu[i, 3], GV.z_eu[i, 0], GV.z_eu[i, 1], GV.z_eu[i, 2]);
                }
            }
            if (GV.nei != 0)
            {
                fout.WriteLine("ИНУТ");
                fout.WriteLine("\t\tn1+\t\tn1-\t\tn2+\t\tn2-\t\tEI");
                for (int i = 1; i <= GV.nei; i++)
                {
                    fout.WriteLine("EI{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    i, GV.in_ei[i, 0], GV.in_ei[i, 1], GV.in_ei[i, 2], GV.in_ei[i, 3], GV.z_ei[i]);
                }
            }
            if (GV.ntri != 0)
            {
                fout.WriteLine("Идеальные трансформаторы");
                fout.WriteLine("\t\tn1+\t\tn1-\t\tn2+\t\tn2-\t\tn");
                for (int i = 1; i <= GV.nei; i++)
                {
                    fout.WriteLine("TRI{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}",
                    i, GV.in_tri[i, 0], GV.in_tri[i, 1], GV.in_tri[i, 2], GV.in_tri[i, 3], GV.z_tri[i]);
                }
            }
            if (GV.nou != 0)
            {
                fout.WriteLine("Операционные усилители");
                fout.WriteLine("\t\tn1+\t\tn1-\t\tn2+\t\tn2-\t\tRi\t\tRo\t\tMu\t\tft");
                for (int i = 1; i <= GV.nou; i++)
                {
                    fout.WriteLine("OU{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t\t{6}\t\t{7}\t\t{8}",
                    i, GV.in_ou[i, 1], GV.in_ou[i, 2], GV.in_ou[i, 3], GV.in_ou[i, 4], GV.z_ou[i, 0], GV.z_ou[i, 1], GV.z_ou[i, 2], GV.z_ou[i, 3]);
                }
            }

            fout.WriteLine("Результаты моделирования");
            if ((GV.lp == 1) && (GV.lm == 0) && (GV.kp == 2) && (GV.km == 0))
            {
                fout.WriteLine("{0,-12}{1,-12}{2,-12}{3,-12}{4,-12}{5,-12}{6,-12}", "f кГц", "kum", "kua", "rim", "ria", "rom", "roa");
                for (int kf = 1; kf <= GV.nf; kf++)
                {
                    fout.WriteLine("{0,-12:F2}{1,-12:E2}{2,-12:F2}{3,-12:E2}{4,-12:F2}{5,-12:E2}{6,-12:F2}",
                    GV.f[kf], GV.kum[kf], GV.kua[kf], GV.rim[kf], GV.ria[kf], GV.rom[kf], GV.roa[kf]);
                }
            }
            else
            {
                fout.WriteLine("{0,-12}{1,-12}{2,-12}{3,-12}{4,-12}", "f кГц", "kum", "kua", "rim", "ria");
                for (int kf = 1; kf <= GV.nf; kf++)
                {
                    fout.WriteLine("{0,-12:F2}{1,-12:E2}{2,-12:F2}{3,-12:E2}{4,-12:F2}",
                    GV.f[kf], GV.kum[kf], GV.kua[kf], GV.rim[kf], GV.ria[kf]);
                }
            }
            fout.Close();
            MessageBox.Show("Описание и результаты выведены в файл  PR.txt");
        }
    }
}