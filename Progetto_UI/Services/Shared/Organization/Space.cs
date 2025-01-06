using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_UI.Services.Shared.Organization
{
    public class Space
    {
        [Key]
        public Int32 Id { get; set; }

        public Int32 WarehouseId { get; set; }
    }
}
