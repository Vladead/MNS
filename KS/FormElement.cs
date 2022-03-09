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
                                GlobalValues.w[i, j] += g / z_d[kd];
                                break;
                            case 'C':
                                GlobalValues.w[i, j] += g * GlobalValues.s * z_d[kd];
                                break;
                            case 'L':
                                GlobalValues.w[i, j] += g / (GlobalValues.s * z_d[kd]);
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
                                GlobalValues.a[i, j] += g / z_d[kd];
                                break;
                            case 'C':
                                GlobalValues.b[i, j] += g * z_d[kd];
                                break;
                        }
                    }
                }
            else
            {
                for (int kd = 1; kd <= nd; kd++)
                {
                    i = GlobalValues.n + kd;
                    GlobalValues.b[i, i] = z_d[kd];
                    for (m = 0; m <= 1; m++)
                    {
                        j = in_d[kd, m];
                        if (j == 0) continue;
                        g = 1 - 2 * m;
                        GlobalValues.a[i, j] -= g;
                        GlobalValues.a[j, i] += g;
                    }
                }

                GlobalValues.n += nd;
            }
        }

        public static void form_w()
        {
            int i, j;
            float t;
            for (i = 1; i <= GlobalValues.n; i++)
            {
                for (j = 1; j <= GlobalValues.n; j++)
                {
                    t = GlobalValues.b[i, j];
                    if (t != 0) t *= GlobalValues.om;
                    GlobalValues.w[i, j] = new Complex(GlobalValues.a[i, j], t);
                }
            }
        }
    }
}