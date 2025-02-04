﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models{
    public class Categoria{
        
        public int id { get; set; }

        [Display(Name= "Descrição")]
        [Required(ErrorMessage = " O campo descrição é obrigatório")]
        public string descricao { get; set; }
        //public List<Produto> produtos { get; set; }
    }
}
