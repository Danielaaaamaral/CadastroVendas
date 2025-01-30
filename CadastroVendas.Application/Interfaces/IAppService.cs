
using CadastroVendas.Application.DTO;
using CadastroVendas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVendas.Application.Interfaces
{
    public interface IAppService
    {
        #region Produto
        Task AddProduto(ProdutoDTO obj);

        Task<ProdutoDTO> GetByIdProduto(int id);

        Task<IEnumerable<ProdutoDTO>> GetAllProduto();

        Task UpdateProduto(ProdutoDTO obj);

        Task RemoveProduto(ProdutoDTO obj);
        #endregion
        #region Cliente
        Task AddCliente(ClienteDTO obj);

        Task<ClienteDTO> GetByIdCliente(int id);

        Task<IEnumerable<ClienteDTO>> GetAllCliente();

        Task UpdateCliente(ClienteDTO obj);

        Task RemoveCliente(ClienteDTO obj);
        #endregion
        #region Venda
        Task AddVenda(VendaDTO obj);

        Task<VendaDTO> GetByIdVenda(int id);

        Task<IEnumerable<VendaDTO>> GetAllVenda();

        Task UpdateVenda(VendaDTO obj);

        Task RemoveVenda(VendaDTO obj);
        #endregion
    }
}
