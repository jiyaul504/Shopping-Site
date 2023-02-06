//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Shopping_Site.Models
//{
//    public class Currency
//    {
//        [Key]
//        public int Id { get; set; }
//        [Required]
//        [StringLength(25)]
//        public string Name { get; set; }
//        [Required]
//        [StringLength(50)]
//        public string Description { get; set; }


//        [Required]
//        [ForeignKey("Currencies")]

//        public int ExchangeCurrencyId { get; set; }

//        public virtual Currency Currencies { get; set; }
//        [Column(TypeName = "smallmoney")]
//        [Required]

//        public decimal ExchangeRate { get; set; }
//    }
//}
