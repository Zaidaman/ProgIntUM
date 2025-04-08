using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_UI.Services.Shared
{
    public class Warehouse
    {
        [Key]
        public int WarehouseId { get; set; }
        public string Name { get; set; }
    }
}
