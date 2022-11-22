using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalFiap.Models
{
    public class Doacoes
    {
        
        public int Id { get; set; }

        public DateTime Data { get; set; }

        
        public string Clinica { get; set; }

        
        public float QntSangue { get; set; }

        
        public string Sentimento { get; set; }

    }
}
