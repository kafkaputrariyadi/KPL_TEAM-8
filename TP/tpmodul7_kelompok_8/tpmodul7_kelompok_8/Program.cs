using System;
using tpmodul7_kelompok_8;

class Program
{
    static void Main(string[] args)
    {
        KuliahMahasiswa2311104054 kuliahMahasiswa = new KuliahMahasiswa2311104054();
        kuliahMahasiswa.ReadJSON();

        DataMahasiswa2311104054.ReadJSON();
    }
}
