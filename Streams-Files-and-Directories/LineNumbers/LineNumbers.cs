namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] strings = File.ReadAllLines(inputFilePath);
            int letters = 0;
            int marks = 0;
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                for (int i = 0; i < strings.Length; i++)
                {
                    using (StreamReader reader = new StreamReader(inputFilePath))
                    {

                        string line = strings[i];
                        foreach (char item in line)
                        {
                            if (Char.IsLetter(item))
                            {
                                letters++;
                            }
                            else if (Char.IsPunctuation(item))
                            {
                                marks++;
                            }

                        }
                        string wrLine = strings[i];
                        int numberOfLines = 0;
                        writer.WriteLine($"Line {++numberOfLines}: {wrLine} ({letters})({marks})");

                        letters = 0;
                        marks = 0;
                    }
                }
                
            }
            
        }
    }
}
