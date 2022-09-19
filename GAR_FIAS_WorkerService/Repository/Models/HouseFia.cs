using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Keyless]
    public partial class HouseFia
    {
        [Required]
        [StringLength(36)]
        public string HouseFiasGuid { get; set; }
        [StringLength(36)]
        public string AoGuid { get; set; }
        [StringLength(50)]
        public string HouseNum { get; set; }
        [StringLength(50)]
        public string BuildNum { get; set; }
        [StringLength(50)]
        public string StrucNum { get; set; }
        [StringLength(36)]
        public string PostalCode { get; set; }
        [StringLength(36)]
        public string Oktmo { get; set; }
        public int? HouseType { get; set; }
    }
}
