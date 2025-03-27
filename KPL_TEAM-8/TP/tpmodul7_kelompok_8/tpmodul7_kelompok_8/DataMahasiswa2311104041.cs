using System;
using System.IO;
using Newtonsoft.Json;


class Program
{
    static void Main()
    {

        DataMahasiswa2311104041 dataMahasiswa = new DataMahasiswa2311104041();

        dataMahasiswa.ReadJSON();
    }
}

public class NamaLengkap
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class Mahasiswa
{
    public NamaLengkap nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }
}

public class DataMahasiswa2311104041  // Ganti sesuai NIM kamu
{
    public void ReadJSON()
    {
        try
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tp7_1_2311104041.json");
            Console.WriteLine($"📂 Mencari file di: {path}");

            if (!File.Exists(path))
    
            {
                Console.WriteLine("❌ File JSON tidak ditemukan!");
                return;
            }

            string jsonData = File.ReadAllText(path);
            Console.WriteLine($"📂 Isi JSON: {jsonData}");

            Mahasiswa mahasiswa = JsonConvert.DeserializeObject<Mahasiswa>(jsonData);

            if (mahasiswa == null)
            {
                Console.WriteLine("❌ Data JSON kosong atau tidak sesuai format!");
                return;
            }

            Console.WriteLine($"✅ Nama {mahasiswa.nama.depan} {mahasiswa.nama.belakang} dengan NIM {mahasiswa.nim} dari Fakultas {mahasiswa.fakultas}");
        }
        catch (JsonException jsonEx)
        {
            Console.WriteLine($"❌ JSON Error: {jsonEx.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Terjadi kesalahan: {ex.Message}");

        }
    }
}