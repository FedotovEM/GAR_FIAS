using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AddressObjectLevel")]
    public partial class AddressObjectLevel
    {
        [Key]
        [Column("AddressObjectLevelID")]
        public int AddressObjectLevelId { get; set; }
        [Required]
        [StringLength(50)]
        public string AddressObjectLevelName { get; set; }

        [InverseProperty("AddressObjectLevel")]
        public virtual AddressObjectLevelRecord AddressObjectLevelRecord { get; set; }
    }
}
