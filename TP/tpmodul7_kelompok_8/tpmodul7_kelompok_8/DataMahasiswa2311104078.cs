using System;
using System.IO;
using Newtonsoft.Json;

class DataMahasiswa2311104078
{
    public string Nama { get; set; }
    public string Nim { get; set; }
    public string Fakultas { get; set; }

    public static void ReadJSON()
    {
        string path = "tp7_1_2311104078.json"; 
        string json = File.ReadAllText(path);

        DataMahasiswa2311104078 data = JsonConvert.DeserializeObject<DataMahasiswa2311104078>(json);

        Console.WriteLine($"Nama {data.Nama} dengan nim {data.Nim} dari fakultas {data.Fakultas}");
    }
}
