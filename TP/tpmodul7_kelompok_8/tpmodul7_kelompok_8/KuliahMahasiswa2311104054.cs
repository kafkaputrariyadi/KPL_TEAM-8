using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_8
{
    public class Course
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class KuliahMahasiswa2311104054
    {
        public List<Course> Courses { get; set; }

        public void ReadJSON()
        {
            string filePath = "tp7_2_2311104054.json";

            try
            {
                string jsonData = File.ReadAllText(filePath);

                KuliahMahasiswa2311104054 kuliahMahasiswa = JsonSerializer.Deserialize<KuliahMahasiswa2311104054>(jsonData);

                if (kuliahMahasiswa != null && kuliahMahasiswa.Courses != null)
                {
                    for (int i = 0; i < kuliahMahasiswa.Courses.Count; i++)
                    {
                        var course = kuliahMahasiswa.Courses[i];
                        Console.WriteLine($"MK {i + 1} {course.Code} - {course.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("Deserialisasi gagal! Data tidak lengkap atau null.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Kesalahan: {ex.Message}");
            }
        }
    }
}
