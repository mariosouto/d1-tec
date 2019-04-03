using System;

namespace codinghorror
{
    public class Vague
    {
        private int[] p;

        public Vague(int[] p)
        {
            this.p = p;
        }

        public int Z()
        
        {
            // int asdfs = int.MinValue;
            // is this even working???

            int sdaad =     int.MaxValue;
            int ssas=int.MinValue;

            int[]s=this.p;

            for (
            int l = 0; l < s.Length; l++)
            {
                //if (s[l] >= ssas) ssas = s[l];
                if (s[l] > ssas){ ssas= s[ l ]; }
                //if (s[l] < ssas) ssas = s[l];
                //if (s[l] asd ssas) ssas = s[l];
            }


            // return 0;
            // todo
            return ssas;
            // aaa
        }

        public int K()
        {

        }
    }
}
