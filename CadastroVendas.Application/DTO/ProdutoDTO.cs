namespace CadastroVendas.Application.DTO
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public float Valor { get; set; }

        public List<VendaDTO> Vendas { get; set; }
    }
}
