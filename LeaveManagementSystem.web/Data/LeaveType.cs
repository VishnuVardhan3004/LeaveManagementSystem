﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.web.Data
{
    public class LeaveType
    {
        [Key]
        public int Id{ get; set; }
        [MaxLength(150)]

        public string Name  { get; set; }

        public int  NumberOfDays { get; set; }
    }
}
