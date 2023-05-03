using EmployeeManagement.API.Entities.DTO;
using EmployeeManagement.API.Entities;
using EmployeeManagement.API.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
        
    {
        /// <summary>
        /// API Lấy danh sách phòng ban
        /// </summary>
        /// <param name="keyword">Từ khoá muốm tìm kiếm</param>
        /// <param name="limit">Số bản ghi muốn lấy</param>
        /// <param name="offset">Vị trí phòng ban</param>
        /// <returns>
        /// Trả về một bản Pagingresult danh sách Phòng ban
        /// Trong một trang và số bản ghi thoả mãn điều kiện
        /// </returns>
        [HttpGet]
        public IActionResult GetPaging
          ([FromQuery] string? keyword,
           [FromQuery] int limit = 10,
           [FromQuery] int offset = 0)
        {
            return Ok(new Pagingresult
            {
                Data = new List<object>
                {
                    new Department
                    {
                        Id= Guid.NewGuid(),
                        Code= "PB001",
                        Name= "Phong Giam Doc"
                    },
                    new Department
                    {
                        Id= Guid.NewGuid(),
                        Code= "PB002",
                        Name="Phong Thu Ky"
                    },
                    new Department
                    {
                        Id= Guid.NewGuid(),
                        Code= "PB003",
                        Name="Phong Maketing"
                    }
                },
                TotalRecords = 3

            });
        }
    }
}
