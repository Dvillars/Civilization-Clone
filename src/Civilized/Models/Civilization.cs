using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Civilized.Models
{
    [Table("Civilizations")]
    public class Civilization
    {
        [Key]
        public int CivilizationId { get; set; }
        public string Name { get; set; }
        public string Pro { get; set; }
        public string Con { get; set; }
        public string Description { get; set; }
    }
}
