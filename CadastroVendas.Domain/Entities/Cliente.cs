using System.Collections.Generic;

namespace CadastroVendas.Domain.Entities
{
    public class Cliente
    {
        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Venda> Vendas { get; set; } = new List<Venda>();
    }
}
