using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaStore
{
    [Table("Product")]
    public class ProductRecord
    {
        [Key] [Column(TypeName ="nvarchar(150)")] public string Id { get; set; } = "";
        [Column(TypeName = "nvarchar(150)")]public string? CategoryName { get; set; }
        [Column(TypeName = "nvarchar(200)")] public string ProductName { get; set; } = "";
        [Column(TypeName = "nvarchar(1000)")] public string? ProductDescription { get; set; } = "";
        public int Price { get; set; }
    }
}