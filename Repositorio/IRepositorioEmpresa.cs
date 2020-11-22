using Aula2FSNET.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2FSNET.Repositorio
{
  public interface IRepositorioEmpresa
  {
    IEnumerable<Empresa> GetTodasEmpresas();
  }
}
