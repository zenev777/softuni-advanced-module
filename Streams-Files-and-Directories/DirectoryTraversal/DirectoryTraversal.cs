namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary <string, List<FileInfo>> map = 
                new SortedDictionary<string, List<FileInfo>>();
            
            string[] fileNames = Directory.GetFiles(inputFolderPath);
            
            foreach (string file in fileNames)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (!map.ContainsKey(fileInfo.Extension))
                {
                    map[fileInfo.Extension] = new List<FileInfo>();
                }
                map[fileInfo.Extension].Add(fileInfo);
            }
            StringBuilder sb = new StringBuilder();
            foreach (var ext in map.OrderByDescending(ex => ex.Value.Count))
            {
                sb.AppendLine(ext.Key);
                foreach (var item in ext.Value.OrderBy(i => i.Length))
                {
                    sb.AppendLine($"--{item.Name} - {(double)item.Length/1024:f3}kb");
                }
            }

            return sb.ToString(); 
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pathToDesktop = Path.Combine(path, reportFileName);

            File.WriteAllText(pathToDesktop, textContent);
        }
    }
}
