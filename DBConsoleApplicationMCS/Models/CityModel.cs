using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    
    [Table("city")]
    public class CityModel
    {

        public CityModel(string? city)
        {
            City = city;
        }

        [Column("city")]
        public string City { get; set; }
        
        [Column("country_id")]
        public string CountryId { get; set; }
        
        [Key] [Column("city_id")]
        public string CityId { get; set; }
    }
}