using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_UI.Services.Shared
{
    public class Space
    {
        [Key]
        public int Id { get; set; }

        public int WarehouseId { get; set; }

        public int Product { get; set; }
    }
}
