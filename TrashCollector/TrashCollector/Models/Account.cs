using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool IsSuspended { get; set; } = false;
        public DayOfWeek? PickupDay { get; set; }
        public DayOfWeek? OneTimePickup { get; set; }
        public DateTime? StartDay { get; set; }
        public DateTime? EndDay { get; set; }
        public Double? Balance { get; set; }

        [ForeignKey("History")]
        public int? HistoryId { get; set; }
        public History History { get; set; }
    }
}
