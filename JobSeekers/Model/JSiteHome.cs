using System.ComponentModel.DataAnnotations;

namespace JobSeekers.Model
{
    public class JSiteHome
    {
        [Key]
        public string jobtype { get; set; }
        public string jobId { get; set; }
        public string jobsalary { get; set; }
    }
}
