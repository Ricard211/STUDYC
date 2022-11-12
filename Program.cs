using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadCsvFile();
            Console.Read();
        }
        
        
        public static void ReadCsvFile()
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ';',
                UseFieldIndexForReadingData = false
            };
            var csvContext = new CsvContext();
            var sellers = csvContext.Read<Seller>("alcohol_licenses.csv", csvFileDescription);
           foreach(var building in sellers)
            {
              int k = 10;
              string[] words = {building.address};
              TopKFrequent( words, 10);
            }
             IList<string> TopKFrequent(string[] words, int k) {
        // Use a map to get the frequency of each word
        var frequency = new Dictionary<string, int>();
        foreach (var word in words) {
            frequency[word] = frequency.GetValueOrDefault(word, 0) + 1;
        }
 
        // Get the frequency map as a list and sort
        var frequencyList = frequency.ToList();
        frequencyList.Sort((a, b) => {
            // If words have the same frequency, sort
            // by their lexicographical order
            if (a.Value == b.Value) {
                return string.Compare(a.Key, b.Key);
            }
            // Sort by the frequency from highest to lowest
            return b.Value - a.Value;
        });
 
        // Get the results
        var result = new List<string>();
        for (int index = 0; index < frequencyList.Count; ++index) {
            result.Add(frequencyList[index].Key);
            if (result.Count == k) {
                break;
            }
        }
        return result;
    }
         
              }
            
        }
       
 



    }

