using System.ComponentModel.DataAnnotations;

namespace timesheet.Model
{
    public class Timesheet
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string OnLeave { get; set; }
        public string Project { get; set; }
        public string Subject { get; set; }
        public string Batch { get; set; }
        public string Summary { get; set; }
        public string Room { get; set; }
    }
}
