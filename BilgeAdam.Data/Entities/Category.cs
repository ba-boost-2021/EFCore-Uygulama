using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.Data.Entities
{
    [Table("Categories")]
    public class Category
    {
        //[Required]
        //[Key]
        public int CategoryID { get; set; }
        //[MaxLength(15)]
        //[Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
