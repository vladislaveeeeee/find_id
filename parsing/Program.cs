using System;
using System.IO;

class Program
{
    static void Main()
    {
        string response = @"0;1375081017007083525; @telegram @apple @GooglePlay;875607916480311296;;;;;;";

        string[] lines = response.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            if (parts.Length >= 4)
            {
                string authorId = parts[3];
                Console.WriteLine("Author ID: " + authorId);
            }
        }
    }
}