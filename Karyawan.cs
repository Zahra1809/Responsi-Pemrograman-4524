using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4524
{
    public class Karyawan
    {
        public Karyawan()
        {

        }

        public Karyawan(string nik, string nama, float gaji, float naikgaji)
        {
            Nik = nik;
            Nama = nama;
            Gaji = gaji;
            NaikGaji = naikgaji;
        }

        public string Nik { get; set; }
        public string Nama { get; set; }
        public float Gaji { get; set; }
        public float NaikGaji { get; set; }


    }
}
