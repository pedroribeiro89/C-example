using System;
using System.ComponentModel.DataAnnotations;

namespace Aula2FSNET.Modelo
{
    public class Disco
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Banda")]
        public string Banda { get; set; }

        [Required]
        [Display(Name = "Estilo")]
        public string Estilo { get; set; }

        [Required]
        [Display(Name = "Ano")]
        public int Ano { get; set; }


        [Required]
        [Display(Name = "Data Inclusão")]
        public DateTime DataInclusao { get; set; }

        [Display(Name = "Data Última Atualização")]
        public DateTime DataUltimaAtualizacao { get; set; }


        public Disco()
        {
        }
    }
}
