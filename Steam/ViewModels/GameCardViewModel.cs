using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steam.ViewModels
{
    public class GameCardViewModel
    {
        public Game Game { get; set; }
        public bool IsInCard { get; set; }
    }
}
