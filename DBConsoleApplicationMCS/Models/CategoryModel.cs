using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("category")]
    public class CategoryModel
    {
        public CategoryModel(string? category)
        {
            Category = category;
        }
        [Key] [Column("category_id")]
        public int CategoryId { get; set;}
            
        [Column("category")]
        public string Category { get; set;}
        
    }
}