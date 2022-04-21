using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4524
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan();
            karyawan1.Nik = "190302123";
            karyawan1.Nama = "Paijo";
            karyawan1.Gaji = 3000000;
            float gaji = 0;
            karyawan1.NaikGaji = NaikGaji(gaji);
            CetakHasil(karyawan1);

            Console.WriteLine();

            Karyawan karyawan2 = new Karyawan();
            karyawan2.Nik = "190302124";
            karyawan2.Nama = "Jono";
            karyawan2.Gaji = 2000000;
            float gaji = 0;
            karyawan2.NaikGaji = NaikGaji(gaji);
            CetakHasil(karyawan2);

            Console.WriteLine();

            Console.ReadKey();
        }

        static void CetakHasil (Karyawan karyawan)
        {
            Console.WriteLine("NIK : {0}", karyawan.Nik);
            Console.WriteLine("Nama : {0}", karyawan.Nama);
            Console.WriteLine("Gaji bulanan : {0}", karyawan.Gaji);

            Console.WriteLine();

            Console.WriteLine("Asyiiik kenaikan gaji 10%!!");

            Console.WriteLine("NIK : {0}", karyawan.Nik);
            Console.WriteLine("Nama : {0}", karyawan.Nama);
            Console.WriteLine("Gaji bulanan : {0}", karyawan.NaikGaji);
        }
        static int NaikGaji(float gaji)
        {
            gaji = Convert.ToInt32(gaji);
            return (0.01 * gaji) + gaji;
        }
    }
    

}
