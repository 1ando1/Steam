using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string? Trailer { get; set; }     //відео
        public string Name { get; set; }
        public double Weight { get; set; }      //розмір гри
        public string Creator { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
    }
}
