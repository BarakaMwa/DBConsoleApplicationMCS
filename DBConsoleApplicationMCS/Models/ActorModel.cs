using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ActorModel
    {
        [Key] [Column("actor_id")] public int Id { get; set; }
        [Column("first_name")] public string? FirstName { get; set; }
        [Column("last_name")] public string? LastName { get; set; }

        public ActorModel()
        {
        }

        public ActorModel(string? firstName, string? lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}