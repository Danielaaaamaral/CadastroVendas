using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVendas.Application.DTO
{
    public class VendaDTO
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int ClienteId { get; set; }
        public float ValorTotal { get; set; }
        public DateTime DtaVenda { get; set; }
    }
}
