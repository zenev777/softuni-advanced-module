namespace EvenLines
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = "";
                int count = 0;
                string regex = @"[-,.!?]";
                Regex reg = new Regex(regex);
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (count % 2 == 0)
                    {

                        Match match = reg.Match(line);
                        if (match.Success)
                        {
                            string newLine = reg.Replace(line, "@");
                            string[] l = newLine.Split(' ');
                            for (int i = l.Length - 1; i >= 0; i--)
                            {
                                Console.Write($"{l[i]} ");
                            }
                            Console.WriteLine();
                        }

                    }
                    count++;
                }
            }
            return null;
        }
    }
}
