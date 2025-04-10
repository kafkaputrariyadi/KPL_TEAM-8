using Newtonsoft.Json;

class MataKuliah
{
    [JsonProperty("kode")]
    public string Kode { get; set; }

    [JsonProperty("nama")]
    public string Nama { get; set; }
}

class KuliahMahasiswa2311104078
{
    [JsonProperty("mata_kuliah")]
    public List<MataKuliah> MataKuliah { get; set; }

    public static void ReadJSON()
    {
        string path = "tp7_2_2311104078.json";
        string json = File.ReadAllText(path);
        KuliahMahasiswa2311104078 data = JsonConvert.DeserializeObject<KuliahMahasiswa2311104078>(json);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (var mk in data.MataKuliah)
        {
            Console.WriteLine($"MK {i} {mk.Kode} - {mk.Nama}");
            i++;
        }
    }
}
