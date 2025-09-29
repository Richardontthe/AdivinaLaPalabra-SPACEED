using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AdivinaLaPalabraRicardoHernandez
{
    internal class FileHandler
    {
        public string FilePath { get; set; }

        public FileHandler()
        {
            string basePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string path = Path.Combine(basePath, "Files", "Words.csv");
            FilePath = path ;
        }

        

        /// <summary>
        /// Method to read words from a CSV file and return them as a list of strings.
        /// </summary>
        /// <returns>List of words</returns>
        /// <exception cref="Exception"></exception>

        public List<string> getWords()
        {
            try
            {
                List<string> words = new List<string>();
                string[] wordString = File.ReadAllLines(FilePath);
                for (int i = 0; i < wordString.Length; i++)
                {
                    wordString[i] = wordString[i].Trim();
                    String[] wordSplit = wordString[i].Split(',');
                    for (int j = 0; j < wordSplit.Length; j++)
                    {
                        if (!string.IsNullOrWhiteSpace(wordSplit[j]))
                            words.Add(wordSplit[j].Trim());
                    }
                }

                return words;

            }
            catch (Exception ex)
            {
                throw new Exception("Error reading file: " + ex.Message);
            }


        }
    }
}
