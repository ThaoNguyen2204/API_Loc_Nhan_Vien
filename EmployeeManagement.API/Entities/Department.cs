namespace EmployeeManagement.API.Entities
{
    public class Department
    {
        /// <summary>
        /// Khoá chính
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Mã phòng ban
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Tên phòng ban
        /// </summary>
        public string Name { get; set; }
    }
}
