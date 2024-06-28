using System.Runtime.InteropServices.JavaScript;

namespace Lab_Feedback
{
    internal class Assignment
    {
        public string? Name { get; }
        public string? Folder { get; }

        public JSObject Results { get; } 

        public Assignment(string? name, string? folder)
        {

            Name = name;
            Folder = folder;
        }

        // This could be a bad idea.
        public static List<Assignment> FindLabOrPracticalSubfolders(string folder)
        {
            var assignments = new List<Assignment>();

            // Recursively search for subfolders that meet the criteria
            SearchSubfolders(folder, assignments);

            // Return assignments sorted alphabetically
            return assignments
                .OrderBy(a => a.Name, StringComparer.OrdinalIgnoreCase).ToList(); ;
        }

        private static void SearchSubfolders(string directoryPath, List<Assignment> assignments)
        {
            // Check if the provided path exists and is a directory
            if (!Directory.Exists(directoryPath))
            {
                Console.Error.WriteLine($"Provided path '{directoryPath}' is not a valid directory.");
                return;
            }

            // Iterate over the directory entries
            foreach (var entry in Directory.GetDirectories(directoryPath))
            {
                var subfolderName = Path.GetFileName(entry);

                // Check if the subfolder name contains "Lab" or "Practical"
                if (subfolderName.StartsWith("Lab ") || subfolderName.StartsWith("Practical"))
                    // Check if the subfolder name contains "Lab" or "Practical"
                {
                    Assignment assignment = new(subfolderName, entry);

                    assignments.Add(assignment);
                }
                else
                {
                    // Recursively search subfolders
                    SearchSubfolders(entry, assignments);
                }
            }
        }
    }
}
