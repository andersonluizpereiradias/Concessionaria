namespace SellCar.Cliente.Model.Models
{
    public class ProfissaoModel
    {
        public int? Id { get; set; }
        public int? TipoProfissaoId { get; set; }
        public string? Descricao { get; set; }
        
        public virtual TipoProfissaoModel? TipoProfissao { get; set; }

    }
}
