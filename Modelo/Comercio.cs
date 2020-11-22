using System.ComponentModel.DataAnnotations;

namespace Aula2FSNET.Modelo
{
  public class Comercio : Empresa
  {
    [Display(Name = "Endereço")]
    [StringLength(250, ErrorMessage = "O limite de caracteres do Endereco é 250")]
    public string Endereco { get; set; }

    public string Segmento { get; set; }
  }
}
