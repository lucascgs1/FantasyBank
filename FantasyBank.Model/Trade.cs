using FantasyBank.Model.interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyBank.Model
{
    public class Trade : ITrade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public double Value { get; set; }

        [Required(ErrorMessage = "The Field {0} is required")]
        [Display(Name = "Cliente Sector", Prompt = "Input the {0}")]
        [MaxLength(50)]
        public string ClientSector { get; set; }

        public TradeCategories? Category { get; set; }
    }
}