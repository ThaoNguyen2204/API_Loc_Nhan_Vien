using EmployeeManagement.API.Entities.DTO;
using EmployeeManagement.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPositionsController : ControllerBase
    {
        /// <summary>
        /// API Lấy danh sách vị trí
        /// </summary>
        /// <param name="keyword">Từ khoá muốm tìm kiếm</param>
        /// <param name="limit">Số bản ghi muốn lấy</param>
        /// <param name="offset">Vị trí bản ghi bắt đầu lấy</param>
        /// <returns>
        /// Trả về một bản Pagingresult danh sách vị trí
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
                    new JobPosition
                    {
                        Id= Guid.NewGuid(),
                        Code= "VT001",
                        Name= "Giam Doc"
                    },
                    new JobPosition
                    {
                        Id= Guid.NewGuid(),
                        Code= "VT002",
                        Name="Thu Ky"
                    },
                    new JobPosition
                    {
                        Id= Guid.NewGuid(),
                        Code= "VT003",
                        Name="Maketing"
                    }
                },
                TotalRecords = 3

            });
        }
    }
}

   
