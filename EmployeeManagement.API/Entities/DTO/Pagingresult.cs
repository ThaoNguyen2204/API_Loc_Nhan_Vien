namespace EmployeeManagement.API.Entities.DTO
{
    /// <summary>
    /// Du lieu tra ve cho aip phan trang
    /// </summary>
    public class Pagingresult
    /// <summary>
    /// Danh sach nhan vien
    /// </summary>
    {
        public List<Employee> Data { get; set; }
        /// <summary>
        /// Tong so ban ghi thoa man dieu kien
        /// </summary>
        public int TotalRecords { get; set; }

    }
}
