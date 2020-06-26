using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw10.DTOs.Requests
{
    public class PromoteStudentRequest
    {
        [Required][MaxLength(100)]public string StudiesName { get; set; }

        [Required]public int Semester { get; set; }
    }
}
