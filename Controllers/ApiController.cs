using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula2FSNET.Data;
using Aula2FSNET.Modelo;
using Aula2FSNET.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Aula2FSNET.Controllers
{
  public class ApiController : Controller
  {
    public IEnumerable<Empresa> GetEmpresas([FromServices] IRepositorioEmpresa repEmpresa)
    {
      return repEmpresa.GetTodasEmpresas();
    }
  }
}
