namespace CarStore.Models
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime DataNasc { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;

        public ICollection<Nota> Notas { get; set; } = new List<Nota>();
    }
}
