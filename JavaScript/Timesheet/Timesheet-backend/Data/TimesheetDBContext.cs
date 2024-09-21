using Microsoft.EntityFrameworkCore;
using timesheet.Model;

namespace timesheet.Data
{
    public class TimesheetDBContext : DbContext
    {
        public TimesheetDBContext(DbContextOptions<TimesheetDBContext> options) : base(options){}

        public DbSet<Timesheet> Timesheets { get; set; }
    }
}
