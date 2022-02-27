using Microsoft.AspNetCore.Identity;

namespace DemoTools.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
