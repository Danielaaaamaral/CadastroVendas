using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVendas.Domain.Entities
{
    public class Venda
    {
        public Venda(int id, int produtoId, int clienteId, DateTime dtaVenda)
        {
            Id = id;
            ProdutoId = produtoId;
            ClienteId = clienteId;
            DtaVenda = dtaVenda;
        }

        public int Id { get; set; }
        public int ProdutoId { get; set;}
        public int ClienteId { get; set; }
        public DateTime DtaVenda { get; set; }

        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
    }
}
