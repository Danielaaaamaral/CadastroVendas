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
    public class ServiceCliente:ServiceBase<Cliente>,IServiceCliente
    {
        public readonly IRepositorioCliente _repositorio;
        public ServiceCliente(IRepositorioCliente repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }

    }
}
