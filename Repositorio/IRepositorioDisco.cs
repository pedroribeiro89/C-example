using System;
using System.Collections.Generic;
using Aula2FSNET.Modelo;

namespace Aula2FSNET.Repositorio
{
    public interface IRepositorioDisco
    {
        IEnumerable<Disco> ListDiscos();
        void CreateDisco(Disco disco);
        Disco GetDisco(string id);
        void EditDisco(Disco disco);
        void DeleteDisco(string id);
    }
}
