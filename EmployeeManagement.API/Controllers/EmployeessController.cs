using EmployeeManagement.API.Entities.DTO;
using EmployeeManagement.API.Entities;
using EmployeeManagement.API.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    /// <summary>
    /// Các API liên quan đến nhân viên
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeessController : ControllerBase
    {
        /// <summary>
        /// API lấy danh sách nhân viêntheo điều kiện lọc và phân trang
        /// </summary>
        /// <param name="keyword">Từ khoá muốn tìm kiếm (Mã nhân viên, Tên và số điện thoại)</param>
        /// <param name="departmentID">Id phòng ban </param>
        /// <param name="jobPositionID">Id vị trí</param>
        /// <param name="limit">Số bản ghi muốn lấy</param>
        /// <param name="offset">Vị trí bản ghi bắt đầu lấy</param>
        /// <returns>
        /// Trả về một đối tượng Pagingresult, bao gồm danh sách nhân viên trên một trang và tông số bản ghi thoả man điều kiện
        /// </returns>
        [HttpGet]
        public IActionResult GetPaging
           ([FromQuery] string? keyword,
           [FromQuery] Guid? departmentID,
           [FromQuery] Guid? jobPositionID,
           [FromQuery] int limit = 10,
           [FromQuery] int offset = 0)
        {
            return Ok(new Pagingresult
            {
                Data = new List<object>
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

            });
        }
        /// <summary>
        /// API Lấy chi tiết một nhân viên
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns>Đối tượng nhân viên muốn lấy
        /// </returns>
        [HttpGet ("{employeeTd}")]
        public IActionResult GetEmployeeById([FromRoute]Guid employeeId)
        {
            return Ok(new Employee
            {
                Id = employeeId,
                Code = "NV003",
                Fullname = "Phung Van Duc",
                Gender = Gender.Other
            });             
        }
        /// <summary>
        /// API lấy mã nhân viên mới tự động tăng 
        /// </summary>
        /// <returns>
        /// Mã nhân viên mới tự động tăng
        /// </returns>
        [HttpGet("new-code")]
        public IActionResult GetNewEmployeeCode()
        {
            return Ok("NV004");
        }
        /// <summary>
        /// API thêm mới nhân viên
        /// </summary>
        /// <param name="newEmployee">Đối tượng nhân viên muốn thêm mới</param>
        /// <returns>
        /// ID của nhân viên vừa thêm mới thành công
        /// </returns>
        [HttpPost]
        public IActionResult InsertEmployee([FromBody] Employee newEmployee)
        {
            return StatusCode(StatusCodes.Status201Created, Guid.NewGuid());
        }
        /// <summary>
        /// API Sửa 
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="updateEmployee"></param>
        /// <returns>ID của nhân viên vừa sửa
        /// </returns>
        [HttpPut("{employeeId}")]
        public IActionResult UpdateEmployee(
            [FromRoute] Guid employeeId,
            [FromBody] Employee updateEmployee)
        {
            return Ok(employeeId);
    }
        /// <summary>
        /// API Xoá
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns>Id của nhân viên vừa xoá
        /// </returns>
        [HttpDelete("{employeeTd}")]
        public IActionResult DeleteEmployee([FromRoute] Guid employeeId)
        {
            return Ok(employeeId);
        }
        
     }
}
