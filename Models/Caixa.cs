using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppEdson.Models
{
    [Table("Caixa")]
    public class Caixa
    {
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Display(Name = "Data Movimentação")]
        public string Data { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Forma Usada")]
        public string Forma { get; set; }

        [Display(Name = "Tipo Movimento")]
        public string Tipo { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Double Valor { get; set; }

    }
}
