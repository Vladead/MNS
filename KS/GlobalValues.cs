
using FRQVS;

namespace KS
{
    class GlobalValues
    {
        public static int M = 100, MR = 50, MC = 50, ML = 20, MF = 20;
        public static int nv, nr, nc, nl, nf;
        public static int lp, lm, kp, km, k;
        public static int[,] in_r = new int[MR + 1, 2];
        public static float[] z_r = new float[MR + 1];
        public static int[,] in_c = new int[MR + 1, 2];
        public static float[] z_c = new float[MR + 1];
        public static int[,] in_l = new int[MR + 1, 2];
        public static float[] z_l = new float[MR + 1];
        public static float[] f = new float[MF + 1];
        public static Complex s;
        public static Complex[,] w = new Complex[M + 1, M + 1];
        public static string filename;
        public static bool flag = false;
        public static float [,] a= new float [M+1,M+1];
        public static float [,] b= new float [M+1,M+1];
        public static float om;
        public static int n;
    }
}
