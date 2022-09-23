using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_ADDR_OBJ_TYPES")]
    public partial class AsAddrObjType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("LEVEL")]
        [StringLength(10)]
        [Unicode(false)]
        public string Level { get; set; }
        [Required]
        [Column("SHORTNAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string Shortname { get; set; }
        [Column("NAME")]
        [StringLength(250)]
        [Unicode(false)]
        public string Name { get; set; }
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

        public static AsAddrObjType GetAttributeValue(XmlReader item)
        {
            AsAddrObjType asAddrObjType = new AsAddrObjType();

            item.MoveToAttribute("ID");
            asAddrObjType.Id = int.Parse(item.Value);
            item.MoveToAttribute("LEVEL");
            asAddrObjType.Level = item.Value;
            item.MoveToAttribute("SHORTNAME");
            asAddrObjType.Shortname = item.Value;
            item.MoveToAttribute("NAME");
            asAddrObjType.Name = item.Value;

            if (item.MoveToAttribute("DESC"))
                asAddrObjType.Desk = item.Value;
            else
                asAddrObjType.Desk = null;

            item.MoveToAttribute("UPDATEDATE");
            asAddrObjType.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asAddrObjType.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asAddrObjType.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1" || IsactiveValue == "true")
                asAddrObjType.Isactive = true;
            else
                asAddrObjType.Isactive = false;

            return asAddrObjType;
        }
    }
}
