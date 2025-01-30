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
    public class RepositorioProduto: RepositorioBase<Produto>, IRepositorioProduto
    {
        private readonly Context _context;

        public RepositorioProduto(Context context)
        {
            _context = context;
        }
    }
}
