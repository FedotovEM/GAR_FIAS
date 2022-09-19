using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Keyless]
    [Table("AddressObject")]
    public partial class AddressObject
    {
        [Required]
        [Column("AddressObjectGUID")]
        [StringLength(36)]
        public string AddressObjectGuid { get; set; }
        [Column("ParentAOGUID")]
        [StringLength(36)]
        public string ParentAoguid { get; set; }
        [StringLength(50)]
        public string TypeShortName { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(10)]
        public string Level { get; set; }
        public bool? IsHouses { get; set; }
        [Column("KLADR")]
        [StringLength(150)]
        public string Kladr { get; set; }
    }
}
