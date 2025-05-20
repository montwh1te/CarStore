namespace CarStore.Models.ViewModels
{
    public class ViewModelNota
    {
        public Nota Nota { get; set; }
        public List<Vendedor> Vendedores { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Carro> Carros { get; set; }
    }
}
