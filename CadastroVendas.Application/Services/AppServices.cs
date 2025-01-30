using AutoMapper;
using CadastroVendas.Application.DTO;
using CadastroVendas.Application.Interfaces;
using CadastroVendas.Domain.Entities;
using CadastroVendas.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVendas.Application.Services
{
    public class AppServices : IAppService
    {
        private readonly IServiceCliente _clienteService;
        private readonly IServiceProduto _produtoService;
        private readonly IServiceVenda _vendaService;
        private readonly IMapper mapper;

        public AppServices(IServiceCliente clienteService, IServiceProduto produtoService, IServiceVenda vendaService, IMapper mapper)
        {
            _clienteService = clienteService;
            _produtoService = produtoService;
            _vendaService = vendaService;
            this.mapper = mapper;
        }

        public async Task AddCliente(ClienteDTO obj)
        {
            var cliente = mapper.Map<Cliente>(obj);
            await _clienteService.Add(cliente);
        }

        public async Task AddProduto(ProdutoDTO obj)
        {
            var produto = mapper.Map<Produto>(obj);
            await _produtoService.Add(produto);
        }

        public async Task AddVenda(VendaDTO obj)
        {
            var venda = mapper.Map<Venda>(obj);
            await _vendaService.Add(venda);
        }

        public async Task<IEnumerable<ClienteDTO>> GetAllCliente()
        {
            var cliente = await _clienteService.GetAll();
            var clienteDto = mapper.Map<IEnumerable<ClienteDTO>>(cliente);
            return clienteDto;
        }

        public async Task<IEnumerable<ProdutoDTO>> GetAllProduto()
        {
            var produto = await _produtoService.GetAll();
            var produtoDto = mapper.Map<IEnumerable<ProdutoDTO>>(produto);
            return produtoDto;
        }

        public async Task<IEnumerable<VendaDTO>> GetAllVenda()
        {
            var venda = await _vendaService.GetAll();
            var vendaDto = mapper.Map<IEnumerable<VendaDTO>>(venda);
            return vendaDto;
        }

        public async Task<ClienteDTO> GetByIdCliente(int id)
        {
            var cliente = await _clienteService.GetById(id);
            var clienteDto = mapper.Map<ClienteDTO>(cliente);
            return clienteDto;
        }

        public async Task<ProdutoDTO> GetByIdProduto(int id)
        {
            var produto = await _produtoService.GetById(id);
            var produtoDto = mapper.Map<ProdutoDTO>(produto);
            return produtoDto;
        }

        public async Task<VendaDTO> GetByIdVenda(int id)
        {
            var venda = await _vendaService.GetById(id);
            var vendaDto = mapper.Map<VendaDTO>(venda);
            return vendaDto;
        }

        public async Task RemoveCliente(ClienteDTO obj)
        {
            var cliente = mapper.Map<Cliente>(obj);
            await _clienteService.Remove(cliente);
        }

        public async Task RemoveProduto(ProdutoDTO obj)
        {
            var produto = mapper.Map<Produto>(obj);
            await _produtoService.Remove(produto);
        }

        public async Task RemoveVenda(VendaDTO obj)
        {
            var venda = mapper.Map<Venda>(obj);
            await _vendaService.Remove(venda);
        }

        public async Task UpdateCliente(ClienteDTO obj)
        {
            var cliente = mapper.Map<Cliente>(obj);
            await _clienteService.Update(cliente);
        }

        public async Task UpdateProduto(ProdutoDTO obj)
        {
            var produto = mapper.Map<Produto>(obj);
            await _produtoService.Update(produto);
        }

        public async Task UpdateVenda(VendaDTO obj)
        {
            var venda = mapper.Map<Venda>(obj);
            await _vendaService.Update(venda);
        }
    }
}
