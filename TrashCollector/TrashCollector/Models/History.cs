using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class History
    {
        [Key]
        public int Id { get; set; }
        public DateTime PickupTime { get; set; }
        public bool IsPickedUp { get; set; }
    }
}
