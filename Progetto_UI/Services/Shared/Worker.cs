﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_UI.Services.Shared
{
    public class Worker
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int action { get; set; }
    }
}
