using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2FSNET.Modelo
{
  public class Empresa
  {
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    [Display(Name = "CNPJ")]
    [StringLength(40, ErrorMessage = "O limite de caracteres do CNPJ é 40")]
    public string CNPJ { get; set; }

    [Display(Name = "Site")]
    [StringLength(500, ErrorMessage = "O limite de caracteres do Site é 500")]
    public string Site { get; set; }

    [Display(Name = "Endereço do portal")]
    [StringLength(250, ErrorMessage = "O limite de caracteres do Nome é 250")]
    public string Nome { get; set; }
  }
}
