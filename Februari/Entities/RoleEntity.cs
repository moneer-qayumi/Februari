﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Februari.Entities
{
    internal class RoleEntity
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; } = null!;
    }
}
