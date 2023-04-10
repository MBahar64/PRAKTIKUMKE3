using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan_ke3
{
    public class Program
    {
        static void Main(string[] args)
        {
            mahasiswa mahasiswa1 = new mahasiswa();
            mahasiswa mahasiswa2 = new mahasiswa();

            mahasiswa1.NAMA = "bahar";
            mahasiswa1.NIM = "22.11.4935";
            mahasiswa1.IPK = 3.50f;
            mahasiswa2.NAMA = "sayang";
            mahasiswa2.NIM = "22.11.4935";
            mahasiswa2.IPK = 3.50f;


            mahasiswa1.Registrasi();
            mahasiswa1.IsiKRS();
            mahasiswa2.Registrasi();
            mahasiswa2.IsiKRS();

            Console.ReadKey();
        }
    }
}
