using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Civilized.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public virtual ApplicationUser AssignedUserId { get; set; }
        public virtual Player HasPlayerId { get; set; }
    }
}
