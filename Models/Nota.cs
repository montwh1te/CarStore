using System.ComponentModel.DataAnnotations;

namespace CarStore.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public string Numero { get; set; } = string.Empty;
        public DateTime DataEmissao { get; set; }
        public string Garantia { get; set; } = string.Empty;
        public decimal ValorVenda { get; set; }

        public int CompradorId { get; set; }
        public Cliente Comprador { get; set; } = null!;

        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; } = null!;

        public int CarroId { get; set; }
        public Carro Carro { get; set; } = null!;
    }
}
