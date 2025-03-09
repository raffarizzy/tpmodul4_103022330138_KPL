using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022330138
{
    class KodePos
    {
        private static string[] kota = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
        private static int[] kodePosKota = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40272, 40274, 40273, 40275 };

        public static int GetKodePos(string namaKota)
        {
            for (int i = 0; i < kota.Length; i++)
            {
                if (kota[i] == namaKota)
                {
                    return kodePosKota[i];
                }
            }
            throw new ArgumentException("Kode pos tidak ditemukan untuk kota: " + namaKota);
        }
    }
}