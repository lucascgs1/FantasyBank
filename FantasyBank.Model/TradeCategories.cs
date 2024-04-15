using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FantasyBank.Model
{
    public class TradeCategories
    {
        [ForeignKey("Trade")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TradeId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public string Category { get; set; }
    }
}