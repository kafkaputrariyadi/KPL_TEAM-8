using System;
using System.IO;
using Newtonsoft.Json;

public class KuliahMahasiswa2311104066
{
    public static void ReadJSON()
    {
        // Path file JSON
        string filePath = "tp7_2_2311104066.json";

        // Pastikan file ada sebelum membaca
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File JSON tidak ditemukan!");
            return;
        }

        // Baca file JSON
        string jsonData = File.ReadAllText(filePath);

        // Deserialize JSON ke object
        CourseList daftarKuliah = JsonConvert.DeserializeObject<CourseList>(jsonData);

        if (daftarKuliah?.Courses == null)
        {
            Console.WriteLine("Gagal membaca data mata kuliah!");
            return;
        }

        // Cetak hasil deserialisasi
        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (var course in daftarKuliah.Courses)
        {
            Console.WriteLine($"MK {i} {course.Code} - {course.Name}");
            i++;
        }
    }
}
