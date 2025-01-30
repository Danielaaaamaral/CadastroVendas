using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVendas.Application.DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<VendaDTO> Vendas { get; set; }
    }
}
