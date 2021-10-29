using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Refactor_Project_Series.Models
{
    public class Serie
    {
        public int Id { get; set; }
        
        [Display(Name = "Título")]
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }
        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "O campo gênero é obrigatório")]
        public int GeneroId { get; set; }
        [Display(Name = "Gênero")]
        public Genero Genero { get; set; }

    }
}
