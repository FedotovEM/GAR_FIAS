using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsFormsAppGAR.Repository.Models
{
    [Table("AS_ADDR_OBJ_PARAMS")]
    public partial class AsAddrObjParams
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Column("CHANGEIDEND")]
        public long Changeidend { get; set; }
        [Column("TYPEID")]
        public int Typeid { get; set; }
        [Required]
        [Column("VALUE")]
        [StringLength(36)]
        public string Value { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }

        public static AsAddrObjParams GetAttributeValue(XmlReader item)
        {
            AsAddrObjParams asAddrObjParams = new AsAddrObjParams();

            item.MoveToAttribute("ID");
            asAddrObjParams.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asAddrObjParams.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEID");
            asAddrObjParams.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEIDEND");
            asAddrObjParams.Changeidend = long.Parse(item.Value);
            item.MoveToAttribute("TYPEID");
            asAddrObjParams.Typeid = int.Parse(item.Value);
            item.MoveToAttribute("VALUE");
            asAddrObjParams.Value = item.Value;
            item.MoveToAttribute("UPDATEDATE");
            asAddrObjParams.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asAddrObjParams.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asAddrObjParams.Enddate = DateTime.Parse(item.Value);

            return asAddrObjParams;
        }
    }
}
