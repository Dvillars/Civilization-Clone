using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Civilized.Models
{
    [Table("Economies")]
    public class Economy
    {
        [Key]
        public int EconomyId { get; set; }
        public string Name { get; set; }
        public string Pro { get; set; }
        public string Con { get; set; }
        public string Description { get; set; }
    }
}
