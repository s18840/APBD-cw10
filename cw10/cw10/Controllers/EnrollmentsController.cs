using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw10.DTOs.Requests;
using cw10.DTOs.Responses;
using cw10.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw10.Controllers
{
    [ApiController]
    [Route("api/enrollments")]
    public class EnrollmentsController : ControllerBase
    {
        private IDbService service;

        public EnrollmentsController(IDbService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> EnrollStudent(EnrollStudentRequest request)
        {
            await service.EnrollStudent(request);

            var response = new EnrollStudentResponse()
            {
                IndexNumber = request.IndexNumber,
                FirstName = request.FirstName,
                LastName = request.LastName,
                BirthDate = request.BirthDate,
                Study = request.StudiesName,
                Semester = 1
            };
            return CreatedAtAction("EnrollStudent", response);
        }


        [HttpPost("promotions")]
        public async Task<IActionResult> PromoteStudent(PromoteStudentRequest request)
        {
            return Ok(await service.PromoteStudent(request));

        }
    }
}