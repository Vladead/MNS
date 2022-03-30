
using FRQVS;

namespace KS
{
    class GV
    {
        public static int M = 100, MR = 50, MC = 50, ML = 20, MF = 20,
            MJU = 20, MEU = 20, MJI = 20, MEI = 20, MTRI = 20, MOUI = 20, MTR = 20, MTB = 20, MTU = 20, MOU = 20;
        public static int nv, nr, nc, nl, nf, ntri, ntr, nju, nei, nji, neu;
        public static int lp, lm, kp, km, k;
        public static int[,] in_r = new int[MR + 1, 2];
        public static float[] z_r = new float[MR + 1];
        public static int[,] in_c = new int[MC + 1, 2];
        public static float[] z_c = new float[MC + 1];
        public static int[,] in_l = new int[ML + 1, 2];
        public static float[] z_l = new float[ML + 1];

        public static int[,] in_tri = new int[MTR + 1, 4];
        public static float[] z_tri = new float[MTR + 1];

        //массивы трансформаторов
        public static int[,] in_tr = new int[MTR + 1, 4];
        //номинал
        public static float[,] z_tr = new float[MTR + 1, 5];

        //массивы ИТУН
        public static int[,] in_ju = new int[MJU + 1, 4];
        //номинал
        public static float[,] z_ju = new float[MJU + 1, 3];

        //массивы ИНУТ
        public static int[,] in_ei = new int[MEI + 1, 4];
        //номинал
        public static float[] z_ei = new float[MEI + 1];
        
        //массивы ИНУН
        public static int[,] in_eu = new int[MEU + 1, 4];
        // номинал
        public static float[,] z_eu = new float[MEU + 1, 3];
        
        //массивы ИТУТ
        public static int[,] in_ou = new int[MOU + 1, 4];
        // номинал
        public static float[,] z_ou = new float[MOU + 1, 3];

        //массивы ИТУТ
        public static int[,] in_ji = new int[MJI + 1, 4];
        //номинал
        public static float[] z_ji = new float[MJI + 1];

        public static float[] f = new float[MF + 1];
        public static Complex s;
        public static Complex[,] w = new Complex[M + 1, M + 1];
        
        public static string filename;
        public static bool flag = false;
        
        public static float [,] a= new float [M+1,M+1];
        public static float [,] b= new float [M+1,M+1];
        public static float om;
        public static int n;
        
        public static float[] kum = new float[MF + 1];
        public static float[] kua = new float[MF + 1];
        public static float[] rim = new float[MF + 1];
        public static float[] ria = new float[MF + 1];
        public static float[] rom = new float[MF + 1];
        public static float[] roa = new float[MF + 1];
    }
}
