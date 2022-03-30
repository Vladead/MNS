using FRQVS;

namespace KS
{
    public class FormElement
    {
        public static void form_d(ref int[,] in_d, float[] z_d, int nd, char td)
        {
            int i, j, g;
            for (int kd = 1; kd <= nd; kd++)
            {
                for (int l = 0; l <= 1; l++)
                {
                    i = in_d[kd, l];
                    if (i == 0) continue;
                    for (int m = 0; m <= 1; m++)
                    {
                        j = in_d[kd, m];
                        if (j == 0) continue;
                        g = (1 - 2 * l) * (1 - 2 * m);
                        switch (td)
                        {
                            case 'R':
                                GV.w[i, j] = GV.w[i, j] + g / z_d[kd];
                                break;
                            case 'C':
                                GV.w[i, j] += g * GV.s * z_d[kd];
                                break;
                            case 'L':
                                GV.w[i, j] += g / (GV.s * z_d[kd]);
                                break;
                        }
                    }
                }
            }
        }

        public static void form1_d(ref int[,] in_d, ref float[] z_d, int nd, char td)
        {
            int i, j, l, m, g;
            if (td != 'L')
                for (int kd = 1; kd <= nd; kd++)
                for (l = 0; l <= 1; l++)
                {
                    i = in_d[kd, l];
                    if (i == 0) continue;
                    for (m = 0; m <= 1; m++)
                    {
                        j = in_d[kd, m];
                        if (j == 0) continue;
                        g = (1 - 2 * l) * (1 - 2 * m);
                        switch (td)
                        {
                            case 'R':
                                GV.a[i, j] += g / z_d[kd];
                                break;
                            case 'C':
                                GV.b[i, j] += g * z_d[kd];
                                break;
                        }
                    }
                }
            else
            {
                for (int kd = 1; kd <= nd; kd++)
                {
                    i = GV.n + kd;
                    GV.b[i, i] = z_d[kd];
                    for (m = 0; m <= 1; m++)
                    {
                        j = in_d[kd, m];
                        if (j == 0) continue;
                        g = 1 - 2 * m;
                        GV.a[i, j] -= g;
                        GV.a[j, i] += g;
                    }
                }

                GV.n += nd;
            }
        }

        public static void form_w()
        {
            int i, j;
            float t;
            for (i = 1; i <= GV.n; i++)
            {
                for (j = 1; j <= GV.n; j++)
                {
                    t = GV.b[i, j];
                    if (t != 0) t *= GV.om;
                    GV.w[i, j] = new Complex(GV.a[i, j], t);
                }
            }
        }

        public static void form_tri()
        {
            int i, j, g;
            for (int ktri = 1; ktri <= GV.ntri; ktri++)
            {
                i = GV.n + ktri;
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_tri[ktri, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i, j] += g * GV.z_tri[ktri];
                        GV.w[j, i] -= g * GV.z_tri[ktri];
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i, j] -= g;
                        GV.w[j, i] += g;
                    }
                }
            }

            GV.n += GV.ntri;
        }

        public static void form_tr()
        {
            int i1, i2, j, g;
            for (int ktr = 1; ktr <= GV.ntr; ktr++)
            {
                i1 = GV.n + ktr;
                i2 = i1 + GV.ntr;
                GV.w[i1, i1] = GV.z_tr[ktr, 0] + GV.s * GV.z_tr[ktr, 2];
                GV.w[i2, i2] = GV.z_tr[ktr, 1] + GV.s * GV.z_tr[ktr, 3];
                GV.w[i1, i2] = GV.s * GV.z_tr[ktr, 4];
                GV.w[i2, i1] = GV.s * GV.z_tr[ktr, 4];
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_tr[ktr, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i1, j] -= g;
                        GV.w[j, i1] += g;
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i2, j] -= g;
                        GV.w[j, i2] += g;
                    }
                }
            }

            GV.n += 2 * GV.ntr;
        }

        //Формирование комплексных частных матриц ИТУН 
        public static void form_ju()
        {
            int i, j, g;
            for (int kju = 1; kju <= GV.nju; kju++)
            for (int l = 2; l <= 3; l++)
            {
                i = GV.in_ju[kju, l];
                if (i == 0) continue;
                for (int m = 0; m <= 1; m++)
                {
                    j = GV.in_ju[kju, m];
                    if (j == 0) continue;
                    g = (5 - 2 * l) * (l - 2 * m);
                    GV.w[i, j] += g * GV.z_ju[kju, 0];
                }
            }
        }

        //Формирование комплексных частных матриц ИНУТ
        public static void form_ei()
        {
            int i1, i2, j, g;
            for (int kei = 1; kei <= GV.nei; kei++)
            {
                i1 = GV.n + kei;
                i2 = i1 + GV.nei;
                GV.w[i2, i1] = new Complex(GV.z_ei[kei], 0);
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_ei[kei, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i1, j] = GV.w[i1, j] - g;
                        GV.w[j, i1] = GV.w[j, i1] + g;
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i2, j] = GV.w[i2, j] - g;
                        GV.w[j, i2] = GV.w[j, i2] + g;
                    }
                }
            }

            GV.n += 2 * GV.nei;
        }

        //Формирование комплексных частных матриц ИТУТ
        public static void form_ji()
        {
            int i, j, g;
            for (int kji = 1; kji <= GV.nji; kji++)
            {
                j = GV.n + kji;
                for (int l = 0; l <= 3; l++)
                {
                    i = GV.in_ji[kji, l];
                    if (i == 0) continue;
                    if (l < 2)
                    {
                        g = l - 2 * l;
                        GV.w[i, j] = GV.w[i, j] + g;
                        GV.w[j, j] -= g;
                    }
                    else
                    {
                        g = 5 - 2 * l;
                        GV.w[i, j] += g * GV.z_ji[kji];
                    }
                }
            }

            GV.n += GV.nji;
        }

        // ИНУН
        public static void form_eu()
        {
            Complex ms = new Complex(0, 0);
            int i, j, g;
            for (int keu = 1; keu <= GV.neu; keu++)
            {
                ms = GV.z_eu[keu, 0] * (1 + GV.s * GV.z_eu[keu, 1]) / (1 + GV.s * GV.z_eu[keu, 2]);
                i = GV.n + keu;
                for (int m = 0; m <= 3; m++)
                {
                    j = GV.in_eu[keu, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i, j] += g * ms;
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i, j] -= g;
                        GV.w[j, i] += g;
                    }
                }
            }

            GV.n += GV.neu;
        }

        public static void form_s()
        {
            for (int i = 1; i <= GV.M; i++)
                GV.w[i, 0] = new Complex(0, 0);
            if (GV.lp != 0)
                GV.w[GV.lp, 0] = new Complex(-1, 0);
            if (GV.lm != 0)
                GV.w[GV.lm, 0] = new Complex(1, 0);
        }
    }
}