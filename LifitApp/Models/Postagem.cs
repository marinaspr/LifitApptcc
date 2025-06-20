using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifitApp.Models
{
    public class Postagem
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public string Horario { get; set; }
        public string ImagemUrl { get; set; } // opcional
    }

}
