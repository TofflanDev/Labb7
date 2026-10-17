using Labb7.GPT;
using System.Text.Json;

namespace Labb7
{
    internal static class DataReader
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions()
        {
            WriteIndented = true,
            IncludeFields = true,
        };
        public static void Save(List<Character> characterList, string path)
        {

            string json = JsonSerializer.Serialize(characterList, Options);
            File.WriteAllText(path, json);

        }

        public static List<T> Load<T>(string path)
        {
            string json = File.ReadAllText(path);

            if (string.IsNullOrWhiteSpace(json))
            {
                return [];

            }

            return JsonSerializer.Deserialize<List<T>>(json, Options) ?? [];
        }

    }
}
