using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Feedback
{
    internal class FileHandler
    {
        public static string SearchFile(string path, string filename)
        {
            var files = Directory.GetFiles(path, filename, SearchOption.AllDirectories);
            if (files.Length > 0)
            {
                return files[0]; // Return the first found file
            }

            return "";

            // throw new FileNotFoundException($"File '{filename}' not found in path '{path}'");
        }

        public static List<Result> ParseFile(string filepath)
        {
            var results = new List<Result>();
            var lines = File.ReadAllLines(filepath);

            foreach (var line in lines)
            {
                var parts = line.Split(new[] { " - " }, StringSplitOptions.None);
                if (parts.Length == 2 && int.TryParse(parts[1], out var number))
                {
                    results.Add(new Result(parts[0], number));
                }
            }

            return results;
        }

        public static List<string> SearchCppFiles(string path, List<string> exclusions = null)
        {
            // If exclusions is null, initialize it as an empty HashSet
            var exclusionSet = exclusions != null
                ? new HashSet<string>(exclusions, StringComparer.OrdinalIgnoreCase)
                : new HashSet<string>();

            // List to hold the paths of the found .cpp files
            var cppFiles = new List<string>();

            // Search for all .cpp files in the specified path and subdirectories
            var files = Directory.GetFiles(path, "*.cpp", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                // Get the file name without the directory path
                var fileName = Path.GetFileName(file);

                // Add the file to the list if it's not in the exclusions set
                if (!exclusionSet.Contains(fileName))
                {
                    cppFiles.Add(file);
                }
            }

            return cppFiles;
        }

        public static string? GetSubfolderFromPath(string path, string? subFolder)
        {
            if (subFolder == null) return "";

            var index = subFolder.IndexOf(path, StringComparison.Ordinal);

            return (index < 0) ? subFolder : subFolder.Remove(index, path.Length + 1);
        }

    }
}
