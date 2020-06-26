using cw10.DTOs.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw10.Services
{
   public interface IDbService
    {
        Task<IActionResult> GetStudents();
        Task<IActionResult> ModifyStudent(ModifyStudentRequest request);
        Task<IActionResult> DeleteStudent(DeleteStudentRequest request);
        Task<IActionResult> EnrollStudent(EnrollStudentRequest request);
        Task<IActionResult> PromoteStudent(PromoteStudentRequest request);
    }
}
