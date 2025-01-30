using CadastroVendas.Domain.Entities;
using CadastroVendas.Domain.Repositories;
using CadastroVendas.Infracstruture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVendas.Infracstruture.Repositories
{
   
    public class RepositorioVenda : RepositorioBase<Venda>, IRepositorioVenda
    {
        private readonly Context _context;

        public RepositorioVenda(Context context)
        {
            _context = context;
        }
    }
}
