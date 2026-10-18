using System.Text.Json;

namespace Labb7
{
    internal static class DataReader
    {
        // AI suggested and helped set up a "Data" folder to store our files instead of
        // using the Debug folder. We now have a Data folder where we can easily modify
        // and add files, and the JSON files are copied to the Debug Data folder
        // "Copy if newer" properties changed.
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
            // AI suggested adding all the error handling here, as I didn't have any before.
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
