using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ContactWebApp.Model
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public List<ContactDetail> ContactDetails { get; set; }
        [JsonIgnore]
        [ValidateNever]
        // navigation property
        public User User { get; set; }
    }
}
