namespace CarStore.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public string Chassi { get; set; } = string.Empty;
        public decimal Preco { get; set; }

        public string MarcaModelo => $"{Marca} {Modelo}";

        public ICollection<Nota> Notas { get; set; } = new List<Nota>();
    }
}
