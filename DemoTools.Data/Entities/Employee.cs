using System.ComponentModel.DataAnnotations;

namespace DemoTools.Data.Entities
{
    public class Employee : BaseEntity
    {
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;
        public DateTime? Birthday { get; set; }
        public string Address { get; set; } = string.Empty;
    }
}
