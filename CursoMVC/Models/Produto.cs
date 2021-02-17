using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models{
    public class Produto{
        public int id { get; set; }
        
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = " O campo descrição é obrigatório")]
        public string descricao { get; set; }

        [Display(Name = "Quantidade")]
        [Range( 1, 500, ErrorMessage = "Valor máximo excedido")]
        public int quantidade { get; set; }

        public int categoriaId { get; set; }
        
        public Categoria categoria { get; set; }



}
}
