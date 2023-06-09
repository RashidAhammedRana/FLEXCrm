﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FLEXCrm.Models
{
    [Table("failed_jobs")]
    public partial class FailedJob
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("connection")]
        public string Connection { get; set; }
        [Required]
        [Column("queue")]
        public string Queue { get; set; }
        [Required]
        [Column("payload")]
        public string Payload { get; set; }
        [Required]
        [Column("exception")]
        public string Exception { get; set; }
        [Column("failed_at", TypeName = "datetime")]
        public DateTime FailedAt { get; set; }
    }
}
