namespace DemoTools.Data.Entities
{
    public class Position : BaseEntity
    {
        public string PositionName { get; set; } = string.Empty;
        public Guid DepartmentId { get; set; }

        public Department Department { get; set; } = new Department();
    }
}
