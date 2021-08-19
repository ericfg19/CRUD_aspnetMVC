using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AT_CRUD.Models
{
    public class Amigo
    {
        public int AmigoId { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }


        public int Idade { get; set; }

        public DateTime Aniversario { get; set; }
    }
}
