using Microsoft.AspNetCore.Identity;

namespace DemoTools.Data.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
