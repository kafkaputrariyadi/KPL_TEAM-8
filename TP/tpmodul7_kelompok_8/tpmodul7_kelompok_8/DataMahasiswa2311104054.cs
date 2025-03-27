using System;
using System.IO;
using System.Text.Json;
namespace tpmodul7_kelompok_8;

public class Nama
{
    public string Depan { get; set; }
    public string Belakang { get; set; }
}

public class DataMahasiswa2311104054
{
    public Nama Nama { get; set; }
    public long NIM { get; set; }
    public string Fakultas { get; set; }

    public static void ReadJSON()
    {
        string filePath = "tp7_1_2311104054.json";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File JSON tidak ditemukan!");
            return;
        }

        string jsonData = File.ReadAllText(filePath);
        var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa2311104054>(jsonData);

        if (mahasiswa != null && mahasiswa.Nama != null)
        {
            Console.WriteLine($"Nama {mahasiswa.Nama.Depan} {mahasiswa.Nama.Belakang} dengan nim {mahasiswa.NIM} dari fakultas {mahasiswa.Fakultas}");
        }
        else
        {
            Console.WriteLine("Deserialisasi gagal!");
        }
    }
}
