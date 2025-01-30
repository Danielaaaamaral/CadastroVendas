using AutoMapper;
using CadastroVendas.Application.DTO;
using CadastroVendas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVendas.Application.Mappers
{
    public class MapperProfile :Profile
    {
        protected MapperProfile()
        {
            CreateMap<VendaDTO, Venda>().ReverseMap();

            CreateMap<Cliente, ClienteDTO>()
                .ReverseMap()
                .ForMember(x => x.Vendas, y => y.MapFrom(c => c.Vendas));

            CreateMap<Produto, ProdutoDTO>()
              .ReverseMap()
              .ForMember(x => x.Vendas, y => y.MapFrom(c => c.Vendas));



        }


    }
}
