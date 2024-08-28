namespace SellCar.Cliente.Model.Models
{
    public class TipoProfissaoModel
    {
        public TipoProfissaoModel()
        {
            Profissoes = new HashSet<ProfissaoModel>();
        }

        public int? Id { get; set; }
        public string? Descricao { get; set; }
        
        public ICollection<ProfissaoModel>? Profissoes { get; set; }

    }
}
