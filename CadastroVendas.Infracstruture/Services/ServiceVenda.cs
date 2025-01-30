using CadastroVendas.Domain.Entities;
using CadastroVendas.Domain.Repositories;
using CadastroVendas.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVendas.Infracstruture.Services
{
  
    public class ServiceVenda : ServiceBase<Venda>, IServiceVenda
    {
        public readonly IRepositorioVenda _repositorio;
        public ServiceVenda(IRepositorioVenda repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }

    }
}
