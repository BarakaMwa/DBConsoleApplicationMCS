using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    
    [Table("country")]
    public class CountryModel
    {

        public CountryModel(string? country)
        {
            Country = country;
        }

        [Column("country")]
        public string Country { get; set; }
        
        [Key] [Column("country_id")]
        public string Id { get; set; }
    }
}