namespace KS
{
    public class FormElement
    {
        public void form_d(ref int[,] in_d, float[] z_d, int nd, char td)
        {
            int i, j, g;
            GlobalValues.s = 0.16;
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

            int p = 0;
        }
    }
}