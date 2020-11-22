using System;
using System.Collections.Generic;
using Aula2FSNET.Modelo;
using Aula2FSNET.Repositorio;

namespace Aula2FSNET.Business
{
    public class DiscoBusiness
    {
        private IRepositorioDisco _repDiscos;
        public DiscoBusiness(IRepositorioDisco repDisco)
        {
            _repDiscos = repDisco;
        }

        public IEnumerable<Disco> listDiscos()
        {
            return _repDiscos.ListDiscos();
        }

        public Disco GetDisco(string id)
        {
            return _repDiscos.GetDisco(id);
        }

        internal void CreateDisco(Disco disco)
        {
            _repDiscos.CreateDisco(disco);
        }

        internal void EditDisco(Disco disco)
        {
            _repDiscos.EditDisco(disco);
        }

        internal void DeleteDisco(string id)
        {
            _repDiscos.DeleteDisco(id);
        }
    }
}
