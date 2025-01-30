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
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        public readonly IRepositorioProduto _repositorio;
        public ServiceProduto(IRepositorioProduto repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }

    }
}
