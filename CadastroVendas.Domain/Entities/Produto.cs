using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVendas.Domain.Entities
{
    public class Produto
    {
        public Produto(int id, string nome, float valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public float Valor { get; set; }
        public ICollection<Venda> Vendas { get; set; } = new List<Venda>();
    }
}
