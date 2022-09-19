using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AddressObjectLevelGar")]
    public partial class AddressObjectLevelGar
    {
        public AddressObjectLevelGar()
        {
            AddressObjectLevelRecords = new HashSet<AddressObjectLevelRecord>();
        }

        [Key]
        [Column("GarLevelID")]
        public int GarLevelId { get; set; }
        [Required]
        [StringLength(150)]
        public string GarLevelName { get; set; }

        [InverseProperty(nameof(AddressObjectLevelRecord.GarLevel))]
        public virtual ICollection<AddressObjectLevelRecord> AddressObjectLevelRecords { get; set; }
    }
}
