using CsvHelper.Configuration.Attributes;
using LINQtoCSV;
using System;

namespace HelloWorld
{
    public class Seller
    {
        /*[CsvColumn(Name = "ADDRESS", FieldIndex = 6)]
        public string? address { get; set; } */  
        [Index(6)]
        public string? address { get; set; }
    }
}