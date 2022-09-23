using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_ADDHOUSE_TYPES")]
    public partial class AsAddhouseType
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

        public static AsAddhouseType GetAttributeValue(XmlReader item)
        {
            AsAddhouseType asAddhouseType = new AsAddhouseType();

            item.MoveToAttribute("ID");
            asAddhouseType.Id = int.Parse(item.Value);
            item.MoveToAttribute("NAME");
            asAddhouseType.Name = item.Value;

            if (item.MoveToAttribute("SHORTNAME"))
                asAddhouseType.Shortname = item.Value;
            else
                asAddhouseType.Shortname = null;

            if (item.MoveToAttribute("DESC"))
                asAddhouseType.Desk = item.Value;
            else
                asAddhouseType.Desk = null;            

            item.MoveToAttribute("UPDATEDATE");
            asAddhouseType.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asAddhouseType.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asAddhouseType.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1" || IsactiveValue == "true")
                asAddhouseType.Isactive = true;
            else
                asAddhouseType.Isactive = false;

            return asAddhouseType;
        }
    }
}
