using Aula2FSNET.Data;
using Aula2FSNET.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2FSNET.Repositorio
{
  public class RepositorioEmpresa : IRepositorioEmpresa
  {
    private ApplicationDbContext _contexto;
    public RepositorioEmpresa(ApplicationDbContext contexto)
    {
      _contexto = contexto;
    }

    public IEnumerable<Empresa> GetTodasEmpresas()
    {
      return _contexto.Empresa.ToList();
    }
  }
}
