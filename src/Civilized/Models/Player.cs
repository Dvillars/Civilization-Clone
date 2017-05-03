using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Civilized.Models
{
    [Table("Players")]
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public virtual Civilization Civilization { get; set; }
        public virtual Geography Geography { get; set; }
        public virtual Economy Economy { get; set; }
        public virtual Government Government { get; set; }

    }
}
