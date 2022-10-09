using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_22._10._09.Models
{
    public class Miasto
    {
        public int ID { get; set; }
        [MinLength(2)]
        public string Nazwa { get; set; } = string.Empty;

        [Display(Name = "Data Założenia")]
        [DataType(DataType.Date)]
        public DateTime DataZałożenia { get; set; }
        [RangeAttribute(0,double.PositiveInfinity)]
        public int Populacja { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [RangeAttribute(0, double.PositiveInfinity)]
        public decimal Powierzchnia { get; set; }
        public string Województwo { get; set; } = string.Empty;
    }
}
