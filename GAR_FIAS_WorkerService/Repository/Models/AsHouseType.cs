using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_HOUSE_TYPES")]
    public partial class AsHouseType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; }
        [Column("SHORTNAME")]
        [StringLength(20)]
        [Unicode(false)]
        public string Shortname { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string Desk { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }
        [Column("ISACTIVE")]
        public bool Isactive { get; set; }

        public static AsHouseType GetAttributeValue(XmlReader item)
        {
            AsHouseType asHouseType = new AsHouseType();

            item.MoveToAttribute("ID");
            asHouseType.Id = int.Parse(item.Value);
            item.MoveToAttribute("NAME");
            asHouseType.Name = item.Value;

            if (item.MoveToAttribute("SHORTNAME"))
                asHouseType.Shortname = item.Value;
            else
                asHouseType.Shortname = null;

            if (item.MoveToAttribute("DESC"))
                asHouseType.Desk = item.Value;
            else
                asHouseType.Desk = null;

            item.MoveToAttribute("UPDATEDATE");
            asHouseType.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asHouseType.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asHouseType.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1" || IsactiveValue == "true")
                asHouseType.Isactive = true;
            else
                asHouseType.Isactive = false;

            return asHouseType;
        }
    }
}
