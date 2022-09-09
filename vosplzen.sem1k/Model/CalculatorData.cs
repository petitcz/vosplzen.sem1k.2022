using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;

namespace vosplzen.sem1k.Model
{
    public class CalculatorData
    {        
        [Required(ErrorMessage = "Toto je povinné pole")]
        [Range(1, int.MaxValue, ErrorMessage ="Hodnota musí větší než 0")]
        public int? Cislo1 { get; set; } = 0;

        [Required(ErrorMessage = "Toto je povinné pole")]
        [Range(1, int.MaxValue, ErrorMessage = "Hodnota musí větší než 0")]
        public int? Cislo2 { get; set; } = 0;
        public int Vysledek { get; set; } = 0;

    }
}
