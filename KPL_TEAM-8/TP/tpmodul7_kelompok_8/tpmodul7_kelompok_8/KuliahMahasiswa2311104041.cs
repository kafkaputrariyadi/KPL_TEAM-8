using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace KuliahMahasiswa231114041
{
    public class MataKuliah
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class KuliahMahasiswa
    {
        public List<MataKuliah> Courses { get; set; }

        public void ReadJSON()
        {
            string nim = "2311104041"; 
            string fileName = $"tp7_2_{nim}.json";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            if (File.Exists(filePath))
            {
                try
                {
                    string jsonData = File.ReadAllText(filePath);
                    KuliahMahasiswa data = JsonConvert.DeserializeObject<KuliahMahasiswa>(jsonData);

                    if (data?.Courses != null)
                    {
                        Console.WriteLine("Daftar mata kuliah yang diambil:");
                        int index = 1;
                        foreach (var course in data.Courses)
                        {
                            Console.WriteLine($"MK {index} {course.Code} - {course.Name}");
                            index++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data JSON kosong atau tidak sesuai format.");
                    }
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Terjadi kesalahan saat memproses file JSON: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"File JSON tidak ditemukan di: {filePath}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KuliahMahasiswa mahasiswa = new KuliahMahasiswa();
            mahasiswa.ReadJSON();
        }
    }
}
