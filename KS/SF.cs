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
    }
}