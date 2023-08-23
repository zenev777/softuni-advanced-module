namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using FileStream reader = new FileStream(inputFilePath, FileMode.Open);
            using FileStream writer = new FileStream(outputFilePath, FileMode.Create);
            
            byte[] buffer = new byte[1024];
            int bytesRead = 0;
            int count = buffer.Length;
            while ((bytesRead = reader.Read(buffer, 0, buffer.Length))!=0)
            {
                writer.Write(buffer, 0, bytesRead);
            }
            reader.Close();
            writer.Close();
        }
    }
}
