using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models{
    public class Produto{
        public int id { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }
        public int categoriaId { get; set; }
        public Categoria categoria { get; set; }



}
}
