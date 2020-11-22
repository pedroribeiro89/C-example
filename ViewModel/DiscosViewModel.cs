using System;
using System.Collections.Generic;
using Aula2FSNET.Modelo;

namespace Aula2FSNET.ViewModel
{
    public class DiscosViewModel
    {
        public IEnumerable<Disco> discos { get; set; }
        public Disco disco { get; set; }
        public DiscosViewModel()
        {
            
        }
    }
}
