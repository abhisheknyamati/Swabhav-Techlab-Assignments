using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ContactWebApp.Model
{
    public class ContactDetail
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string TypeValue { get; set; }
        [ForeignKey("Contact")]
        public int ContactId { get; set; }
        [JsonIgnore]
        [ValidateNever]
        // navigation property
        public Contact Contact { get; set; }
    }
}
