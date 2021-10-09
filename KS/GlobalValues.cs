using System;
using System.Collections.Generic;
using System.Text;

namespace KS
{
    class GlobalValues
    {
        public static int M = 100, MR = 50, MF = 20;
        public static int nv, nr, nc, nl, k;
        public static int[,] in_r = new int[MR + 1, 2];
        public static float[] z_r = new float[MR + 1];
        public static int[,] in_c = new int[MR + 1, 2];
        public static float[] z_c = new float[MR + 1];
        public static int[,] in_l = new int[MR + 1, 2];
        public static float[] z_l = new float[MR + 1];
        public static float[] f = new float[MF + 1];
        public static string filename;
        public static bool flag = false;

    }
}
