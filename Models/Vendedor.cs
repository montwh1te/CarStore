namespace CarStore.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime DataAdmissao { get; set; }
        public string Matricula { get; set; } = string.Empty;
        public decimal Salario { get; set; }

        public decimal CalcularComissao()
        {
            return Salario * 0.1m;
        }

        public string NomeMatricula => $"{Nome} {Matricula}";

        public ICollection<Nota> Notas { get; set; } = new List<Nota>();
    }
}
