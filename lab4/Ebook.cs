using System;


namespace lab4
{
    public class Ebook : Book
    {
        public string FileFormat { get; set; }

        public override string GetInfo()
        {
            return $"{Title} (Digital: {FileFormat})";
        }
    }
}