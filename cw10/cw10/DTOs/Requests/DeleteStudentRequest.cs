﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw10.DTOs.Requests
{
    public class DeleteStudentRequest
    {
        [Required] public string IndexNumber { get; set; }
    }
}
