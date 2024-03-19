using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaComputadora.DAL;
using SistemaComputadora.MODELOS;

namespace SistemaComputadora.BSS
{
    public class ComputadoraBSS
    {
        ComputadoraDal dal = new ComputadoraDal();
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadorasDal();
        }
        public void InsertarComputadoraBss(Computadora computadora)
        {
            dal.InsertarComputadoraDal(computadora);
        }
    }
}
