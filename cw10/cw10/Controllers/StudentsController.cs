using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw10.DTOs.Requests;
using cw10.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw10.Controllers
{
        [Route("api/students")]
        [ApiController]

        public class StudentsController : ControllerBase
        {
            private IDbService service;

            public StudentsController(IDbService service)
            {
                this.service = service;
            }

            [HttpGet]
            public async Task<IActionResult> GetStudents()
            {
                return Ok(await service.GetStudents());
            }

            [HttpPut()]
            public async Task<IActionResult> UpdateStudentInfo(ModifyStudentRequest request)
            {
                return Ok(await service.ModifyStudent(request));
            }

            [HttpDelete()]
            public async Task<IActionResult> DeleteStudent(DeleteStudentRequest request)
            {
                return Ok(await service.DeleteStudent(request));

            }

        }
    }
