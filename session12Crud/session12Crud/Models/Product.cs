using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace session12Crud.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Column("Product Name", TypeName = "varchar(50)")]
        public string Name { get; set; }

        public int Price { get; set; }
    }
}
