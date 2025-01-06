﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_UI.Services.Shared.Organization
{
    public class Product
    {
        [Key]
        public Int32 Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
