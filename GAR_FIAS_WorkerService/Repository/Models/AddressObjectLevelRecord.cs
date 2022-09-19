using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AddressObjectLevelRecord")]
    public partial class AddressObjectLevelRecord
    {
        [Key]
        [Column("AddressObjectLevelID")]
        public int AddressObjectLevelId { get; set; }
        [Column("GarLevelID")]
        public int? GarLevelId { get; set; }

        [ForeignKey(nameof(AddressObjectLevelId))]
        [InverseProperty("AddressObjectLevelRecord")]
        public virtual AddressObjectLevel AddressObjectLevel { get; set; }
        [ForeignKey(nameof(GarLevelId))]
        [InverseProperty(nameof(AddressObjectLevelGar.AddressObjectLevelRecords))]
        public virtual AddressObjectLevelGar GarLevel { get; set; }
    }
}
