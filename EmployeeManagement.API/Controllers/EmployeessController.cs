using EmployeeManagement.API.Entities.DTO;
using EmployeeManagement.API.Entities;
using EmployeeManagement.API.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    /// <summary>
    /// Cac api lien quan den nhan vien
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeessController : ControllerBase
    {
        /// <summary>
        /// API lay danh sach nhan vien theo dieu kien loc va phan trang
        /// </summary>
        /// <param name="keyword">Tu khoa muon tim kiem (Ma nhan vien, Ten hoac So dien thoai)</param>
        /// <param name="departmentID">Id phong ban </param>
        /// <param name="jobPositionID">Id vi tri</param>
        /// <param name="limit">So ban ghi muon lay</param>
        /// <param name="offset">Vi tri ban ghi bat dau lay</param>
        /// <returns>
        /// Tra ve mot doi tuong Pagingresult, bao gom danh sach nhan vien tren mot trang và tong so ban ghi thoa man dieu kien
        /// </returns>
        [HttpGet]
        public Pagingresult GetPaging([FromQuery] string? keyword,
           [FromQuery] Guid? departmentID,
           [FromQuery] Guid? jobPositionID,
           [FromQuery] int limit=10,
           [FromQuery] int offset=0)
        {
            return new Pagingresult
            {
                Data = new List<Employee>
                {
                    new Employee
                    {
                        Id= Guid.NewGuid(),
                        Code= "NV001",
                        Fullname="Pham Tuan Duy",
                        Gender= Gender.Male
                    },
                    new Employee
                    {
                        Id= Guid.NewGuid(),
                        Code= "NV002",
                        Fullname="Hoang Quoc Tuan",
                        Gender= Gender.Female
                    },
                    new Employee
                    {
                        Id= Guid.NewGuid(),
                        Code= "NV003",
                        Fullname="Phung Van Duc",
                        Gender= Gender.Other
                    }
                },
                TotalRecords = 3

            };
        }
    }
}
