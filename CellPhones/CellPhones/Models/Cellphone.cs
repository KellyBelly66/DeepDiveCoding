using System;

namespace CellPhones.Models
{
    public class Cellphone
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }
        public string ScreenSize { get; set; }
        public string Memory { get; set; }
        public bool Prepaid { get; set; }
    }
}