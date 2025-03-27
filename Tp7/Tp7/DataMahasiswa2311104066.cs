using System;
using System.IO;
using Newtonsoft.Json;
using Tp7;

public class DataMahasiswa2311104066
{
    public Nama Nama { get; set; }  // Ubah dari string ke class Nama
    public string Nim { get; set; }
    public string Fakultas { get; set; }
    public static void ReadJSON()
    {
        string filePath = "tp7_1_2311104066.json"; // Pastikan file ini ada di direktori proyek
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File JSON tidak ditemukan!");
            return;
        }

        // Baca file JSON
        string jsonData = File.ReadAllText(filePath);

        // Tampilkan isi JSON sebelum deserialisasi
        Console.WriteLine("Isi JSON yang dibaca:");
        Console.WriteLine(jsonData);

        // Deserialize JSON ke object
        DataMahasiswa2311104066? mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa2311104066>(jsonData);


        // Cetak hasilnya sesuai format
        Console.WriteLine($"Nama {mahasiswa?.Nama?.depan} {mahasiswa?.Nama?.belakang} dengan nim {mahasiswa?.Nim} dari fakultas {mahasiswa?.Fakultas}");
    }
}
