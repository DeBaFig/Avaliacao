using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Avaliacao.Models
{
    public class NumberModel
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        
        [Required]
        public String Operacao { get; set; }
        

    }
}