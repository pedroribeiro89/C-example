using System;
using System.Collections.Generic;
using System.Linq;
using Aula2FSNET.Data;
using Aula2FSNET.Modelo;

namespace Aula2FSNET.Repositorio
{
    public class RepositorioDisco : IRepositorioDisco
    {
        private ApplicationDbContext _appcontext;

        public RepositorioDisco(ApplicationDbContext appcontext)
        {
            _appcontext = appcontext;
        }

        IEnumerable<Disco> IRepositorioDisco.ListDiscos()
        {
            return _appcontext.Disco.ToList();
        }

        void IRepositorioDisco.CreateDisco(Disco disco)
        {
            disco.DataInclusao = DateTime.Now;
            this._appcontext.Disco.Add(disco);
            this._appcontext.Entry(disco).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            this._appcontext.SaveChanges();
        }

        public Disco GetDisco(string id)
        {
            return _appcontext.Disco
                .AsEnumerable()
                .Where(s => s.Id.ToString().Equals(id)).FirstOrDefault();
        }

        public void EditDisco(Disco disco)
        {
            disco.DataUltimaAtualizacao = DateTime.Now;
            this._appcontext.Disco.Update(disco);
            this._appcontext.Entry(disco).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this._appcontext.SaveChanges();
        }

        public void DeleteDisco(string id)
        {
            Disco disco = GetDisco(id);
            this._appcontext.Entry(disco).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            this._appcontext.SaveChanges();
        }
    }
}
