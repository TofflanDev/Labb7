using System.Text.Json;

namespace Labb7
{
    internal static class DataReader
    {

        private static string GetPath(string fileName) =>
            Path.Combine(AppContext.BaseDirectory, "Data", fileName);

        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions()
        {
            WriteIndented = true,
        };
        public static void Save<T>(List<T> items, string fileName)
        {
            string fullPath = GetPath(fileName);
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath)!);
            File.WriteAllText(fullPath, JsonSerializer.Serialize(items, Options));

        }

        public static List<T> Load<T>(string fileName)
        {

            string fullPath = GetPath(fileName);

            if (!File.Exists(fullPath))
            {
                return [];
            }
            string json = File.ReadAllText(fullPath);

            if (string.IsNullOrWhiteSpace(json))
            {
                return [];

            }

            return JsonSerializer.Deserialize<List<T>>(json, Options) ?? [];
        }

    }
}
